using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_seg_info_subcat
    {
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public int ep_seg_segment_number { get; set; }
        public string ep_seg_subject_category { get; set; }
        public short promotion_status { get; set; }
    }
}
