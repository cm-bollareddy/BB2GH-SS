using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods2_daily_query
    {
        public int kind { get; set; }
        public string pif_nola { get; set; }
        public string episode_nola { get; set; }
        public string re_up { get; set; }
        public string version_nola { get; set; }
        public System.DateTime sched_date { get; set; }
        public int sched_time { get; set; }
        public string sched_id { get; set; }
        public int element_number { get; set; }
        public Nullable<int> element_index { get; set; }
        public string current_distributor { get; set; }
    }
}
