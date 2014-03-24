using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_programs_revisions
    {
        public string nola { get; set; }
        public int npr_key { get; set; }
        public System.DateTime flag_date_time { get; set; }
        public string username { get; set; }
        public string subscript_rpt_trans_chg { get; set; }
        public string program_title_chg { get; set; }
        public string episode_title_chg { get; set; }
        public string stereo_mono_chg { get; set; }
        public string dolby_chg { get; set; }
        public string hdtv_chg { get; set; }
        public string sap_chg { get; set; }
        public string anti_clutter_chg { get; set; }
        public string content_flag_chg { get; set; }
        public string rating_chg { get; set; }
        public string subrating_chg { get; set; }
        public string rating_start_time_chg { get; set; }
        public string special_cond_desc_chg { get; set; }
        public string row_chg { get; set; }
    }
}
