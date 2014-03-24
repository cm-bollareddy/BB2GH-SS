using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class l_translate
    {
        public string supertype { get; set; }
        public string sched_id { get; set; }
        public string nolaroot { get; set; }
        public string subtype { get; set; }
        public short position { get; set; }
        public string time_period { get; set; }
        public string dtmf_type { get; set; }
        public string bugged { get; set; }
        public string toned { get; set; }
        public Nullable<int> break_bug_id { get; set; }
    }
}
