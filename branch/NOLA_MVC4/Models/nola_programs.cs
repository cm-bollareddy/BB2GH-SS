using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NOLA_MVC4.Models
{
    public partial class nola_programs
    {
        public string nola { get; set; }
        [Display(Name = "Subscription Def.")]
        public string subscript_rpt_trans { get; set; }
        public string subscript_rpt_trans_chg { get; set; }
        [Display(Name = "Series Title")]
        public string series_title { get; set; }
        public string series_title_soundex { get; set; }
        [Display(Name = "Program Title")]
        public string program_title { get; set; }
        public string program_title_soundex { get; set; }
        public string program_title_chg { get; set; }
        [Display(Name = "Episode Title")]
        public string episode_title { get; set; }
        public string episode_title_soundex { get; set; }
        public string episode_title_chg { get; set; }
        [Display(Name = "Length")]
        public int program_length { get; set; }
        public string length_indicator { get; set; }
        [Display(Name = "OB Date")]
        public System.DateTime obdate { get; set; }
        [Display(Name = "Uplink")]
        public string uplink { get; set; }
        [Display(Name = "Live Origination")]
        public string live_origination { get; set; }
        [Display(Name = "Original Distributor")]
        public string original_distributor { get; set; }
        [Display(Name = "Current Distributor")]
        public string current_distributor { get; set; }
        public string stereo_mono { get; set; }
        public string stereo_mono_chg { get; set; }
        public string dat { get; set; }
        public string dolby { get; set; }
        public string dolby_chg { get; set; }
        public string color_bw { get; set; }
        public string hdtv { get; set; }
        public string hdtv_chg { get; set; }
        public string sap { get; set; }
        public string sap_chg { get; set; }
        public string anti_clutter { get; set; }
        public string anti_clutter_chg { get; set; }
        public string content_flag { get; set; }
        public string content_flag_chg { get; set; }
        public string rating { get; set; }
        public string rating_chg { get; set; }
        public string subrating { get; set; }
        public string subrating_chg { get; set; }
        public int rating_start_time { get; set; }
        public string rating_start_time_chg { get; set; }
        public string special_condition_desc { get; set; }
        public string special_cond_desc_chg { get; set; }
        public string slate { get; set; }
        public string program_comments { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_revised { get; set; }
        public string row_chg { get; set; }
    }
}
