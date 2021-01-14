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
        private HttpClient _webClient = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(500) };

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

            var userInfo = JsonConvert.DeserializeObject<UserInfo>(userJson);

            if (userInfo.Success != "true")
                throw new ProfileNotFoundException(input);
            
            return userInfo;
        }

        public async Task<Statistics> GetStatisticsAsync(string id)
        {
            var response = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/account/statistics?id={id}");
            var statisticsJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Statistics>(statisticsJson);
        }

        public async Task<ServerStatus> GetServerStatus()
        {
            var response = await _webClient.GetAsync($"https://mariflash.galaxylifereborn.com/status");
            var statusJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ServerStatus>(statusJson);
        }

        private async Task<Leaderboards> GetLeaderboardPlayers()
        {
            var result = await _webClient.GetAsync($"https://api.galaxylifereborn.com/modules/leaderboard");
            var json = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Leaderboards>(json);
        }

        public async Task<IEnumerable<string>> GetTopLevelPlayers()
            => (await GetLeaderboardPlayers()).TopLevelPlayers;

        public async Task<IEnumerable<string>> GetTopChipsPlayers()
            => (await GetLeaderboardPlayers()).TopChipsPlayers;
    }
}
