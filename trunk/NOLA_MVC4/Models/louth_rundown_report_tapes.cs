using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_rundown_report_tapes
    {
        public int sched_index { get; set; }
        public short reel_number { get; set; }
        public int control_number { get; set; }
        public string mb { get; set; }
        public string tape_size { get; set; }
    }
}
