using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_schedule_revisions
    {
        public int sched_index { get; set; }
        public int nss_key { get; set; }
        public System.DateTime flag_date_time { get; set; }
        public string username { get; set; }
        public System.DateTime sched_date { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public string @event { get; set; }
        public int element_index { get; set; }
        public string length_chg { get; set; }
        public string length_indicator_chg { get; set; }
        public string black_time_chg { get; set; }
        public string uplink_chg { get; set; }
        public string current_distributor_chg { get; set; }
        public string xmis_flag_chg { get; set; }
        public string feed_flag_chg { get; set; }
        public string row_inserted { get; set; }
        public string row_chg { get; set; }
    }
}
