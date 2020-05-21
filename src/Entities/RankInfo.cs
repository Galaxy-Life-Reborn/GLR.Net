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
                if (Rank == Rank.Moderator) return 2605694;
                if (Rank == Rank.Tester) return 16729674;
                if (Rank == Rank.Donator) return 15710778;
                if (Rank == Rank.Banned) return 16777215;
                else return 000000;
            }
        }
    }

    public enum Rank
    {
        Banned = 0,
        Member = 1,
        Donator = 2,
        Tester = 3,
        Moderator = 4,
        Developer = 5
    }
}
