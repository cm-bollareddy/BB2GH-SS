using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_rundown_merged_elements
    {
        public int parent_sched_index { get; set; }
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
        public string rundown_comments { get; set; }
    }
}
