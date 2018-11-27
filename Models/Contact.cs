using System;

namespace ColonyGaming_Angular_Web_API.Models
{
    public class Contact
    {
        public long? id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public byte gender { get; set; }
        public DateTime? birth { get; set; }
        public string techno { get; set; }
        public string message { get; set; }
    }
}