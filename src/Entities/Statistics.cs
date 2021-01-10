using GLR.Net.Entities.Enums;
using Newtonsoft.Json;

namespace GLR.Net.Entities
{
    public class Statistics
    {
        [JsonProperty("allianceName")]
        public string Alliance { get; set; }

        [JsonProperty("friendCount")]
        public int Friends { get; set; }

        [JsonProperty("experiencePoints")]
        public long Experience { get; set; }

        [JsonProperty("starbaseLevel")]
        public int Starbase { get; set; }

        [JsonProperty("colonyCount")]
        public int Colonies { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("starName")]
        public string StarName { get; set; }

        [JsonProperty("attacksDone")]
        public int AttacksDone { get; set; }

        [JsonProperty("userStatus")]
        public UserStatus Status { get; set; }

        [JsonProperty("missionsCompleted")]
        public int Missions { get; set; }
    }
}
