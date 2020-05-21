using System;
using GLR.Net.Entities;

namespace GLR.Net.Exceptions
{
    public class StatsNotFoundException : Exception
    {
        public StatsNotFoundException(BasicProfile user)
        {
            User = user;
        }

        public BasicProfile User { get; set; }
        public override string Message => $"User statistics for '{User.Username}' not found.";
    }
}
