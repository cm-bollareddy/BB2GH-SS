using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class alloc_release_statuses
    {
        public System.DateTime sched_date { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public string status_desc { get; set; }
    }
}
