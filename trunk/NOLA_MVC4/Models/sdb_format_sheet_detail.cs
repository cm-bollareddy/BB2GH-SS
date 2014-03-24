using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_format_sheet_detail
    {
        public int detail_id { get; set; }
        public int sheet_reel_id { get; set; }
        public short reel_number { get; set; }
        public int format_sheet_id { get; set; }
        public string segment_type { get; set; }
        public int segment_length { get; set; }
        public int segment_time_in { get; set; }
        public int segment_time_out { get; set; }
        public string segment_notes_cues { get; set; }
    }
}
