using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_reup_episode
    {
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public int sip_number { get; set; }
        public string prime_time { get; set; }
        public System.DateTime ob_date_time { get; set; }
        public string rights_available { get; set; }
        public System.DateTime begin_rights_date { get; set; }
        public System.DateTime end_rights_date { get; set; }
        public string simulcast { get; set; }
        public string radio { get; set; }
        public string non_comm_cable { get; set; }
        public System.DateTime pbs_encore_release_date { get; set; }
        public string selected_episodes { get; set; }
        public string rights_restriction { get; set; }
        public string episode_type { get; set; }
        public string school_rights { get; set; }
        public int school_days { get; set; }
        public int school_months { get; set; }
        public System.DateTime school_expires { get; set; }
        public string bcast_comment { get; set; }
        public short promotion_status { get; set; }
    }
}
