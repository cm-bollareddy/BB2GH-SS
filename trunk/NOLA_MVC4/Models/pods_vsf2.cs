using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods_vsf2
    {
        public System.DateTime sched_date { get; set; }
        public int start_time { get; set; }
        public int star_start_time { get; set; }
        public string sched_id { get; set; }
        public string version_nola { get; set; }
        public int element_index { get; set; }
        public System.DateTime daily_timestamp { get; set; }
        public string operation { get; set; }
    }
}
