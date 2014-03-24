using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_nola_schedule_push
    {
        public System.DateTime run_date_time { get; set; }
        public System.DateTime push_start_date { get; set; }
        public System.DateTime push_end_date { get; set; }
        public short push_status { get; set; }
    }
}
