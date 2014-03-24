using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class xponder_sched_id_val
    {
        public string sched_id { get; set; }
        public int carrier_percentage { get; set; }
        public string satellite_code { get; set; }
        public string xponder_id { get; set; }
        public string carrier_id { get; set; }
        public float downlink_frequency { get; set; }
        public string downlink_polarity { get; set; }
        public string transmission_type { get; set; }
        public int bandwidth { get; set; }
        public string uscs_carrier_id { get; set; }
        public string uscs_flag { get; set; }
        public string data_dump_flag { get; set; }
    }
}
