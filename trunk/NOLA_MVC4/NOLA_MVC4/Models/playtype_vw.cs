using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class playtype_vw
    {
        public string rel_type { get; set; }
        public string episode_nola { get; set; }
        public string event_nola { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string rec_type { get; set; }
        public int rel_id { get; set; }
        public int release_number { get; set; }
        public System.DateTime rel_date_time { get; set; }
        public int rel_time { get; set; }
        public string release_day { get; set; }
        public string release_sched { get; set; }
        public string first_hard_feed { get; set; }
        public System.DateTime rel_end_date_time { get; set; }
        public string release_notes { get; set; }
        public short promotion_status { get; set; }
    }
}
