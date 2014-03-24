using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_rundown_report_events
    {
        public int sched_index { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public int start_time_sec { get; set; }
        public int event_length { get; set; }
        public int event_length_sec { get; set; }
        public string event_length_indicator { get; set; }
        public string @event { get; set; }
        public int element_number { get; set; }
        public int element_index { get; set; }
        public string element_type { get; set; }
        public string element_type_name { get; set; }
        public int black_time { get; set; }
        public int black_time_sec { get; set; }
        public string uplink { get; set; }
        public string current_distributor { get; set; }
        public int black_start_time { get; set; }
        public string black_effect { get; set; }
        public int slate_start_time { get; set; }
        public int slate_length { get; set; }
        public string slate_effect { get; set; }
        public string series_title { get; set; }
        public string program_title { get; set; }
        public string episode_title { get; set; }
        public string origination_flag { get; set; }
        public string live_origination { get; set; }
        public string dolby { get; set; }
        public string stereo_mono { get; set; }
        public string sap { get; set; }
        public string anti_clutter { get; set; }
        public string rating { get; set; }
        public string subrating { get; set; }
        public int rating_start_time { get; set; }
        public string feed_flag { get; set; }
        public string feed_flag_desc { get; set; }
        public string slate { get; set; }
        public string program_comments { get; set; }
        public System.DateTime techeval_date { get; set; }
        public string rundown_comments { get; set; }
        public string subscript_rpt_trans { get; set; }
        public string special_condition_desc { get; set; }
        public string merged { get; set; }
    }
}
