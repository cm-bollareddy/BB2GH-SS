using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sched_delay
    {
        public int sched_delay_key { get; set; }
        public string delay_pattern_code { get; set; }
        public string sched_id { get; set; }
        public string plus_or_minus { get; set; }
        public int delay_minutes { get; set; }
    }
}
