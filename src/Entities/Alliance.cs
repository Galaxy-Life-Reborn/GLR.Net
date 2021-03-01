using Newtonsoft.Json;

namespace GLR.Net
{
    public class Alliance
    {
        [JsonProperty("name")]
        public string Name { get; set; } 

        [JsonProperty("owner")]
        public Owner Owner { get; set; } 

        [JsonProperty("memberCount")]
        public int MemberCount { get; set; } 

        [JsonProperty("emblem")]
        public Emblem Emblem { get; set; } 
    }

    public class Owner
    {
        [JsonProperty("id")]
        public string Id { get; set; } 

        [JsonProperty("name")]
        public string Name { get; set; } 
    }

    public class Emblem
    {
        [JsonProperty("shape")]
        public int Shape { get; set; } 

        [JsonProperty("pattern")]
        public int Pattern { get; set; } 

        [JsonProperty("icon")]
        public int Icon { get; set; } 
    }
}
