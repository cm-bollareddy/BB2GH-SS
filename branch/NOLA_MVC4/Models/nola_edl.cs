using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_edl
    {
        public string nola { get; set; }
        public int cut { get; set; }
        public int start_hours { get; set; }
        public int start_minutes { get; set; }
        public int start_seconds { get; set; }
        public int start_frames { get; set; }
        public int end_hours { get; set; }
        public int end_minutes { get; set; }
        public int end_seconds { get; set; }
        public int end_frames { get; set; }
    }
}
