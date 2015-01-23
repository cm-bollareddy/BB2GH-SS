using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_schedule_del_jnl
    {
        public System.DateTime sched_date { get; set; }
        public int start_time { get; set; }
        public string sched_id { get; set; }
        public string version_nola { get; set; }
        public int element_index { get; set; }
        public System.DateTime timestamp { get; set; }
        public string whodidit { get; set; }
    }
}
