using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_schedule_lookup
    {
        public string sched_id { get; set; }
        public string mcr { get; set; }
        public string dow { get; set; }
        public short rank { get; set; }
        public string crosspoint { get; set; }
    }
}
