using System.Collections.Generic;
using Newtonsoft.Json;

namespace GLR.Net.Entities
{
    public class Leaderboards
    {
        [JsonProperty("top_level_players")]
        public IEnumerable<string> TopLevelPlayers { get; set; }
        [JsonProperty("top_rich_players")]
        public IEnumerable<string> TopChipsPlayers { get; set; }
    }
}
