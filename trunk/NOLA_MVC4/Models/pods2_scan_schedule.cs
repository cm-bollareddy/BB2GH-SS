using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods2_scan_schedule
    {
        public System.DateTime sched_date { get; set; }
        public int start_time { get; set; }
        public string sched_id { get; set; }
        public int element_index { get; set; }
        public int length { get; set; }
        public string length_indicator { get; set; }
        public int black_time { get; set; }
        public string uplink { get; set; }
        public string current_distributor { get; set; }
        public string feed_flag { get; set; }
        public string xmis_flag { get; set; }
    }
}
