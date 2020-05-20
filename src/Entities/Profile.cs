using System;

namespace GLR.Net.Entities
{
    public class Profile : BasicProfile
    {
        public RankInfo RankInfo { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public int AmountOfFriends { get; set; }
        public int AmountOfIncomingRequests { get; set; }
        public int AmountOfOutgoingRequests { get; set; }
    }
}
