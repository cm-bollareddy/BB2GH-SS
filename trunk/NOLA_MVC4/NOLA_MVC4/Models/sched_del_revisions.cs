using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sched_del_revisions
    {
        public int sched_index { get; set; }
        public int sdr_key { get; set; }
        public System.DateTime flag_date_time { get; set; }
        public string username { get; set; }
    }
}
