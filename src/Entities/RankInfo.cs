using GLR.Net.Entities.Enums;

namespace GLR.Net.Entities
{
    public class RankInfo
    {
        public RankInfo(Rank rank)
        {
            Rank = rank;
        }

        public RankInfo(int rank)
        {
            Rank = (Rank) rank;
        }

        public Rank Rank { get; set; }
        public uint ColourValue 
        {
            get 
            {
                switch (Rank)
                {
                    case Rank.Developer: 
                        return 480472;
                    case Rank.Administrator:
                        return 3172029;
                    case Rank.Moderator:
                        return 2605694;
                    case Rank.Tester:
                        return 16729674;
                    case Rank.Supporter:
                        return 15710778;
                    case Rank.Locked:
                        return 16777215;
                    case Rank.Banned:
                        return 16777215;
                    default:
                        return 000000;
                }
            }
        }
    }
}
