using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods2_daily_state
    {
        public string daily_is_running { get; set; }
        public System.DateTime last_daily_for_sif { get; set; }
        public System.DateTime current_daily_for_sif { get; set; }
        public System.DateTime last_daily_for_spf { get; set; }
        public System.DateTime current_daily_for_spf { get; set; }
        public System.DateTime last_daily_for_suf { get; set; }
        public System.DateTime current_daily_for_suf { get; set; }
        public System.DateTime last_daily_for_esf { get; set; }
        public System.DateTime current_daily_for_esf { get; set; }
        public System.DateTime last_daily_for_erf { get; set; }
        public System.DateTime current_daily_for_erf { get; set; }
        public System.DateTime last_daily_for_eif { get; set; }
        public System.DateTime current_daily_for_eif { get; set; }
        public System.DateTime last_daily_for_ecf { get; set; }
        public System.DateTime current_daily_for_ecf { get; set; }
        public System.DateTime last_daily_for_edf { get; set; }
        public System.DateTime current_daily_for_edf { get; set; }
        public System.DateTime last_daily_for_ekf { get; set; }
        public System.DateTime current_daily_for_ekf { get; set; }
        public System.DateTime last_daily_for_vif { get; set; }
        public System.DateTime current_daily_for_vif { get; set; }
        public System.DateTime last_daily_for_vsf { get; set; }
        public System.DateTime current_daily_for_vsf { get; set; }
        public System.DateTime last_daily_for_vff { get; set; }
        public System.DateTime current_daily_for_vff { get; set; }
        public System.DateTime last_daily_for_vpf { get; set; }
        public System.DateTime current_daily_for_vpf { get; set; }
        public System.DateTime last_daily_for_vef { get; set; }
        public System.DateTime current_daily_for_vef { get; set; }
        public string current_daily_filename { get; set; }
    }
}
