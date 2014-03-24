using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class uscs_schedule
    {
        public int alloc_index { get; set; }
        public int sched_index { get; set; }
        public string sched_date { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public string uplink { get; set; }
        public string nola_root { get; set; }
        public int episode_number { get; set; }
        public string nola_subscript { get; set; }
        public string nola_spare { get; set; }
        public string start_time_flag { get; set; }
        public int black_time { get; set; }
        public string xmis_flag { get; set; }
        public string feed_flag { get; set; }
        public string origination_flag { get; set; }
        public string satellite { get; set; }
        public string transponder_id { get; set; }
        public string carrier_id { get; set; }
        public double downlink_frequency { get; set; }
        public double bandwidth { get; set; }
        public string downlink_polarity { get; set; }
        public string transponder_band { get; set; }
        public string transmission_type { get; set; }
        public string event_type { get; set; }
        public string soc_uplink_control { get; set; }
        public string spare_1 { get; set; }
        public int power { get; set; }
        public double eirp { get; set; }
    }
}
