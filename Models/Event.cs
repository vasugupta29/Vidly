using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime Schedule { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Moderator { get; set; }
        public string Category { get; set; }
        public string Sub_Category { get; set; }
        public int Rigor_Rank { get; set; }
        public int[] Attendees { get; set; }
    }
}