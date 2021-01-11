using System;
using GLR.Net.Entities.Enums;
using GLR.Net.JsonConverters;
using Newtonsoft.Json;

namespace GLR.Net.Entities
{
    public class UserInfo
    {
        [JsonProperty("authorization")]
        public string Authorization { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("rankType")]
        public Rank RankInfo { get; set; }

        [JsonProperty("friends")]
        [JsonConverter(typeof(FriendsConverter))]
        public BasicProfile[] Friends { get; set; }

        public string ProfileUrl => $"https://web.galaxylifereborn.com/profile/{Username}";

        public string ImageUrl => $"https://web.galaxylifereborn.com/accounts/avatars/{Id}.png?t={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
    }
}
