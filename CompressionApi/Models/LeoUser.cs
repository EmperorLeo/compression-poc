using System;

namespace CompressionApi.Models
{
    public class LeoUser
    {
        public int UserId { get; set; }
        public Guid AnActualGuid { get; set; }
        public string FunName { get; set; }
        public int CotangentJobTitleId { get; set; }
        public string SuperAwesomeComments { get; set; }
        public bool IsUserInGoodStandingWithLeo { get; set; }
        public DateTime DayOfReckoning { get; set; }
        public ulong ItsASnowflake { get; set; } 
    }
}