using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_schedule
    {
        public int sched_index { get; set; }
        public System.DateTime sched_start { get; set; }
        public string sched_id { get; set; }
        public string start_time_flag { get; set; }
        public string @event { get; set; }
        public int element_index { get; set; }
        public System.DateTime sched_end { get; set; }
        public System.DateTime sched_date { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public int length { get; set; }
        public string length_chg { get; set; }
        public string length_indicator { get; set; }
        public string length_indicator_chg { get; set; }
        public int black_time { get; set; }
        public string black_time_chg { get; set; }
        public string black_effect { get; set; }
        public string slate_effect { get; set; }
        public string uplink { get; set; }
        public string uplink_chg { get; set; }
        public string current_distributor { get; set; }
        public string current_distributor_chg { get; set; }
        public string xmis_flag { get; set; }
        public string xmis_flag_chg { get; set; }
        public string feed_flag { get; set; }
        public string feed_flag_chg { get; set; }
        public string feed_flag_rpt { get; set; }
        public string origination_flag { get; set; }
        public int alloc_index { get; set; }
        public string row_inserted { get; set; }
        public string row_chg { get; set; }
    }
}
