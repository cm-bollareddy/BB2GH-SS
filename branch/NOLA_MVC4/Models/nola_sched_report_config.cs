using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_sched_report_config
    {
        public System.DateTime report_start_date { get; set; }
        public System.DateTime report_end_date { get; set; }
        public string report_group_indicator { get; set; }
        public string report_sched_id1 { get; set; }
        public string report_sched_id2 { get; set; }
        public string report_sched_id3 { get; set; }
        public string report_sched_id4 { get; set; }
        public string sas_report_flag { get; set; }
    }
}
