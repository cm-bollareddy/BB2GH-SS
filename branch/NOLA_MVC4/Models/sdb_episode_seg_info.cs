using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_episode_seg_info
    {
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public short promotion_status { get; set; }
        public string include_in_reports { get; set; }
        public int ep_seg_segment_number { get; set; }
        public string ep_seg_prog_type { get; set; }
        public int ep_seg_segment_length { get; set; }
        public string ep_seg_description { get; set; }
    }
}
