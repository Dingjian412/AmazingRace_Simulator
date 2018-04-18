using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARSimulator.Models
{
    public class TeamPosition
    {
        public string eventId { get; set; }
        public string teamId { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string ptStpPass { get; set; }
    }
}