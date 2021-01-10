namespace GLR.Net.Entities
{
    public class BasicProfile
    {
        public BasicProfile(string id, string name)
        {
            Id = id;
            Username = name;
        }

        public string Id { get; set; }
        public string Username { get; set; }
    }
}
