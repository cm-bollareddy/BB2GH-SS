using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_rights_window
    {
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string record_type { get; set; }
        public int window_number { get; set; }
        public string rights_type { get; set; }
        public string rel_tel { get; set; }
        public string window_type { get; set; }
        public System.DateTime rights_start { get; set; }
        public System.DateTime rights_end { get; set; }
        public int rights_years { get; set; }
        public int rights_months { get; set; }
        public int rights_weeks { get; set; }
        public int rights_days { get; set; }
        public string rights_notes { get; set; }
        public short promotion_status { get; set; }
    }
}
