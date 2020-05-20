using System.Collections.Generic;

namespace GLR.Net.Entities
{
    public class User
    {
        public Profile Profile { get; set; }
        public Statistics Statistics { get; set; }
        public List<BasicProfile> Friends { get; set; }
    }
}
