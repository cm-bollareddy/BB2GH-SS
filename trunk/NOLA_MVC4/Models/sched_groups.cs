using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sched_groups
    {
        public int sched_group_key { get; set; }
        public string sched_group_code { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public string start_time_flag { get; set; }
    }
}
