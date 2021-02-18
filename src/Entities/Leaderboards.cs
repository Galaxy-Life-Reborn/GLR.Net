namespace GLR.Net.Entities
{
    public class ChipsLeaderboardUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public long Chips { get; set; }
    }

    public class ExperienceLeaderboardUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public long Level { get; set; }
        public long Experience { get; set; }
    }
}
