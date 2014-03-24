using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods2_nola_schedule
    {
        public int sched_index { get; set; }
        public System.DateTime sched_date { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public string start_time_flag { get; set; }
        public string @event { get; set; }
        public int element_index { get; set; }
        public int end_time { get; set; }
        public int length { get; set; }
        public string length_indicator { get; set; }
        public int black_time { get; set; }
        public string black_effect { get; set; }
        public string slate_effect { get; set; }
        public string uplink { get; set; }
        public string current_distributor { get; set; }
        public string xmis_flag { get; set; }
        public string feed_flag { get; set; }
        public string origination_flag { get; set; }
        public int alloc_index { get; set; }
    }
}
