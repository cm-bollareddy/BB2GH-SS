using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class l3_dtmf_cues
    {
        public string sched_id { get; set; }
        public string twobefore { get; set; }
        public string onebefore { get; set; }
        public string dtmf_tag { get; set; }
        public string oneafter { get; set; }
        public short tonegroup { get; set; }
    }
}
