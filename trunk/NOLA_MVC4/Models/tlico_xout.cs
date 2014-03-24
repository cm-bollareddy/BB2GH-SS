using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class tlico_xout
    {
        public string nola { get; set; }
        public string root_episode { get; set; }
        public string sub { get; set; }
        public int control_number { get; set; }
        public Nullable<int> shelf_number { get; set; }
        public string in_or_out { get; set; }
        public short reel_number { get; set; }
        public string mb { get; set; }
        public string location { get; set; }
        public string tape_size { get; set; }
    }
}
