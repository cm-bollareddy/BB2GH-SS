using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_pp_recs
    {
        public int sched_index { get; set; }
        public string sched_id { get; set; }
        public int scheduled_time_sec { get; set; }
        public int duration_sec { get; set; }
        public string title { get; set; }
    }
}
