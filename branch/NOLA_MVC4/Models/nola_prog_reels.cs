using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_prog_reels
    {
        public string nola { get; set; }
        public short reel_number { get; set; }
        public int reel_length { get; set; }
        public string reel_outcue { get; set; }
        public string reel_comments { get; set; }
    }
}
