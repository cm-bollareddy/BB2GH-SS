using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_reel_slate
    {
        public string episode_nola { get; set; }
        public string event_nola { get; set; }
        public string pif_nola { get; set; }
        public int reel_number { get; set; }
        public string overlap_indicator { get; set; }
        public string reel_ends_with { get; set; }
        public int overlap_begins_at { get; set; }
        public int overlap_length { get; set; }
        public int overlap_ends_at { get; set; }
        public int reel_length { get; set; }
        public string last_essential_audio { get; set; }
        public string last_essential_video { get; set; }
        public int last_audio_time { get; set; }
        public int last_video_time { get; set; }
        public string slate_text { get; set; }
        public int reel_slate_id { get; set; }
    }
}
