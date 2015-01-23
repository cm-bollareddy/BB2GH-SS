using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_nola_edl
    {
        public string nola { get; set; }
        public int cut { get; set; }
        public int barcode { get; set; }
        public string mb { get; set; }
        public int start_hours { get; set; }
        public int start_minutes { get; set; }
        public int start_seconds { get; set; }
        public int start_frames { get; set; }
        public int dur_hours { get; set; }
        public int dur_minutes { get; set; }
        public int dur_seconds { get; set; }
        public int dur_frames { get; set; }
    }
}
