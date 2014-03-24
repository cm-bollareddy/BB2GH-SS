using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_segment
    {
        public int pdb_segment_key { get; set; }
        public string episode_nola { get; set; }
        public string event_nola { get; set; }
        public string pif_nola { get; set; }
        public int reel_number { get; set; }
        public string segment_type { get; set; }
        public int segment_length { get; set; }
        public int segment_time_in { get; set; }
        public int segment_time_out { get; set; }
        public string segment_notes_cues { get; set; }
        public int reel_slate_id { get; set; }
        public short promotion_status { get; set; }
    }
}
