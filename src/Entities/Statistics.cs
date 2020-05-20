using System;

namespace GLR.Net.Entities
{
    public class Statistics
    {
        public string Username { get; set; }
        public string GalaxyName { get; set; }
        public string AllianceName { get; set; }
        public ulong ExperiencePoints { get; set; }
        public ulong Level { get; set; }
        public ulong Starbase { get; set; }
        public ulong Colonies { get; set; }    
        public AttackStatus AttackStatus { get; set; }
        public DateTime LastOnline { get; set; }
        public Status Status { get; set; }
        public ulong MissionsCompleted { get; set; }
    }

    public enum Status
    {
        Offline = 0,
        Online = 1
    }

    public enum AttackStatus
    {
        NotActive = 0,
        UnderAttack = 1
    }
}
