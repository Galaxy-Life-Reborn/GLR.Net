using System;
using GLR.Net.Entities;

namespace GLR.Net.Exceptions
{
    public class StatsNotFoundException : Exception
    {
        public StatsNotFoundException(string id)
        {
            UserId = id;
        }

        public string UserId { get; set; }
        public override string Message => $"User statistics for '{UserId}' not found.";
    }
}
