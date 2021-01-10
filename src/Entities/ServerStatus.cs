using System;
using Newtonsoft.Json;

namespace GLR.Net.Entities
{
    public class ServerStatus
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }

        [JsonProperty("totalPlayers")]
        public int TotalPlayers { get; set; }

        [JsonProperty("onlinePlayers")]
        public int OnlinePlayers { get; set; }

        [JsonProperty("totalStars")]
        public int TotalStars { get; set; }

        [JsonProperty("totalCommandsExecuted")]
        public int TotalCommandsExecuted { get; set; }

        [JsonProperty("commandsExecutedSinceLaunch")]
        public int CommandsExecutedSinceLaunch { get; set; }

        [JsonProperty("onlineSince")]
        public DateTime OnlineSince { get; set; }
    }
}
