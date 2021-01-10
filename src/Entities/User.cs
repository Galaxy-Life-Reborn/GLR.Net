namespace GLR.Net.Entities
{
    public class User
    {
        public User(UserInfo info, Statistics stats)
        {
            Info = info;
            Statistics = stats;
        }

        public UserInfo Info { get; }
        public Statistics Statistics { get; }
    }
}
