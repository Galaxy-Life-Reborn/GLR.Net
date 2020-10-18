namespace GLR.Net.Entities
{
    public class RankInfo
    {
        public Rank Rank { get; set; }
        public uint ColourValue 
        {
            get 
            {
                if (Rank == Rank.Developer) return 480472;
                else if (Rank == Rank.Moderator) return 2605694;
                else if (Rank == Rank.Tester) return 16729674;
                else if (Rank == Rank.Donator) return 15710778;
                else if (Rank == Rank.Locked) return 16777215;
                else if (Rank == Rank.Banned) return 16777215;
                else return 000000;
            }
        }
    }

    public enum Rank
    {
        Banned = 0,
        Locked = 1,
        Member = 2,
        Donator = 3,
        Tester = 4,
        Moderator = 5,
        Developer = 6
    }
}
