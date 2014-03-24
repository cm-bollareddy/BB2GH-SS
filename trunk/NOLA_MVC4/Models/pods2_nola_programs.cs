using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods2_nola_programs
    {
        public string nola { get; set; }
        public string subscript_rpt_trans { get; set; }
        public string series_title { get; set; }
        public string series_title_soundex { get; set; }
        public string program_title { get; set; }
        public string program_title_soundex { get; set; }
        public string episode_title { get; set; }
        public string episode_title_soundex { get; set; }
        public int program_length { get; set; }
        public string length_indicator { get; set; }
        public System.DateTime obdate { get; set; }
        public string uplink { get; set; }
        public string live_origination { get; set; }
        public string original_distributor { get; set; }
        public string current_distributor { get; set; }
        public string stereo_mono { get; set; }
        public string dat { get; set; }
        public string dolby { get; set; }
        public string color_bw { get; set; }
        public string hdtv { get; set; }
        public string sap { get; set; }
        public string anti_clutter { get; set; }
        public string content_flag { get; set; }
        public string rating { get; set; }
        public string subrating { get; set; }
        public int rating_start_time { get; set; }
        public string special_condition_desc { get; set; }
        public string slate { get; set; }
        public string program_comments { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_revised { get; set; }
    }
}
