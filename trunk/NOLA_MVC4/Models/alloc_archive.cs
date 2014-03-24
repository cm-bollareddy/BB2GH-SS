using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class alloc_archive
    {
        public int alloc_index { get; set; }
        public int sched_index { get; set; }
        public System.DateTime sched_date { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public string uplink { get; set; }
        public string current_distributor { get; set; }
        public string nola_root { get; set; }
        public string block_desc { get; set; }
        public string block_status { get; set; }
        public string requested_by { get; set; }
        public string received_by { get; set; }
        public string billable_flag { get; set; }
        public System.DateTime invoice_date { get; set; }
        public string invoice_number { get; set; }
    }
}
