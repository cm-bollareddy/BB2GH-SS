using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class air_discrepancies
    {
        public int discrepancy_number { get; set; }
        public System.DateTime discrepancy_date { get; set; }
        public string day_of_week { get; set; }
        public string control_room { get; set; }
        public string satellite { get; set; }
        public string sched_id { get; set; }
        public int sched_start_time { get; set; }
        public int start_time { get; set; }
        public int stop_time { get; set; }
        public int duration { get; set; }
        public string nola { get; set; }
        public string operator_name { get; set; }
        public string shift_super_name { get; set; }
        public string uplink { get; set; }
        public string backhaul_uplink { get; set; }
        public string double_illuminated { get; set; }
        public string equipment_failure { get; set; }
        public int etr_number { get; set; }
        public string interrupted { get; set; }
        public string downcut { get; set; }
        public string incorrect_state { get; set; }
        public string incorrect_source { get; set; }
        public string rain_fade_downlink_adv { get; set; }
        public string rain_fade_los_transmit { get; set; }
        public string rain_fade_uplink { get; set; }
        public string upcut { get; set; }
        public string other { get; set; }
        public string problem_description { get; set; }
        public string info_fonted_yn { get; set; }
        public string five_min_checkin_yn { get; set; }
        public string bops_notified_yn { get; set; }
        public string corrective_action { get; set; }
        public string clean_refeed_yn { get; set; }
        public System.DateTime refeed_date { get; set; }
        public string refeed_satellite { get; set; }
        public string refeed_sched_id { get; set; }
        public int refeed_time { get; set; }
        public string refeed_why_not { get; set; }
    }
}
