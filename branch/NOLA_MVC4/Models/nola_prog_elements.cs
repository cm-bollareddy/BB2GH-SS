using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_prog_elements
    {
        public string nola { get; set; }
        public int element_number { get; set; }
        public int element_index { get; set; }
        public string element_type { get; set; }
        public int element_start_time { get; set; }
        public string element_start_time_chg { get; set; }
        public int element_length { get; set; }
        public string element_length_chg { get; set; }
        public string element_color_bw { get; set; }
        public string element_color_bw_chg { get; set; }
        public string element_title_desc { get; set; }
        public string element_title_desc_chg { get; set; }
        public string element_voca_indicator { get; set; }
        public int element_voca_start { get; set; }
        public string element_voca_start_chg { get; set; }
        public int element_voca_length { get; set; }
        public string element_voca_length_chg { get; set; }
        public string element_voca_whynot { get; set; }
        public string element_voca_whynot_chg { get; set; }
        public string element_last_ess_audio { get; set; }
        public string el_last_ess_audio_chg { get; set; }
        public string element_last_ess_video { get; set; }
        public string el_last_ess_video_chg { get; set; }
        public string element_comments { get; set; }
        public string element_comments_chg { get; set; }
        public string row_chg { get; set; }
    }
}
