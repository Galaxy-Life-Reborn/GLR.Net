using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GLR.Net.Entities;
using GLR.Net.Exceptions;
using Newtonsoft.Json;

namespace GLR.Net
{
    public partial class GLRClient
    {
        private HttpClient _webClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1000) };

        public async Task<User> GetUserAsync(string input)
        {
            var userInfo = await GetUserInfo(input);
            var stats = await GetStatisticsAsync(userInfo.Id);

            return new User(userInfo, stats);
        }

        public async Task<UserInfo> GetUserInfo(string input)
        {
            /* Api checks if its an id or username and gets you the corresponding profile */
            var response = await _webClient.GetAsync($"https://api.galaxylifereborn.com/modules/botuser?info={input}");
            var userJson = await response.Content.ReadAsStringAsync();

            if (userJson == "false")
                throw new ProfileNotFoundException(input);

            var userInfo = JsonConvert.DeserializeObject<UserInfo>(userJson);

            if (userInfo.Success != "true")
                throw new ProfileNotFoundException(input);
            
            return userInfo;
        }

        public async Task<Statistics> GetStatisticsAsync(string id)
        {
            var response = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/account/statistics?id={id}");
            var statisticsJson = await response.Content.ReadAsStringAsync();

            if (statisticsJson == "Not ready!")
                throw new ServersNotOnlineException();
            else if (statisticsJson == "Error!")
                throw new StatsNotFoundException(id);

            return JsonConvert.DeserializeObject<Statistics>(statisticsJson);
        }

        public async Task<ServerStatus> GetServerStatus()
        {
            try
            {
                var response = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/status");
                var statusJson = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ServerStatus>(statusJson);
            }
            catch (Exception e)
            {
                throw new ServersNotOnlineException();
            }
        }

        public async Task<IEnumerable<ExperienceLeaderboardUser>> GetTopLevelPlayers()
        {
            var result = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/leaderboard/levels");
            var json = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ExperienceLeaderboardUser>>(json);
        }

        public async Task<IEnumerable<ChipsLeaderboardUser>> GetTopChipsPlayers()
        {
            var result = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/leaderboard/chips");
            var json = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ChipsLeaderboardUser>>(json);
        }

        public async Task<Alliance> GetAllianceByName(string input)
        {
            try
            {
                input = input.Replace(" ", "%20");
                var result = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/alliances/info?name={input}");
                var json = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Alliance>(json);
            }
            catch (System.Exception)
            {
                throw new AllianceNotFoundException(input);
            }
        }

        public async Task<AllianceMember[]> GetAllianceMembers(string input)
        {
            try
            {
                input = input.Replace(" ", "%20");
                var result = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/alliances/members?name={input}");
                var json = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<AllianceMember[]>(json);
            }
            catch (System.Exception)
            {
                throw new AllianceNotFoundException(input);
            }
        }
    }
}
