using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class uscs_sched_id_val
    {
        public string sched_id { get; set; }
        public string satellite { get; set; }
        public string transponder_id { get; set; }
        public float downlink_frequency { get; set; }
        public string downlink_polarity { get; set; }
        public string transmission_type { get; set; }
        public short band_width { get; set; }
        public string band_type { get; set; }
    }
}
