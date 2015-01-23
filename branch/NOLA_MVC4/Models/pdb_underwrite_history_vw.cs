using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_underwrite_history_vw
    {
        public int nh_key { get; set; }
        public string funder_code { get; set; }
        public string fy { get; set; }
        public string series_title { get; set; }
        public string pif_title { get; set; }
        public string funder_name { get; set; }
        public string presenter_name { get; set; }
        public string presenter_code { get; set; }
        public string funder_parent { get; set; }
        public string funder_type { get; set; }
        public string funder_class { get; set; }
        public decimal amount_funded { get; set; }
        public decimal acq_prod_cost { get; set; }
        public string generic { get; set; }
        public int num_episodes { get; set; }
        public int length { get; set; }
        public int num2 { get; set; }
        public int len2 { get; set; }
        public System.DateTime pif_obdate { get; set; }
        public System.DateTime rel_date_time_1 { get; set; }
        public System.DateTime rel_date_time_2 { get; set; }
        public System.DateTime rel_date_time_3 { get; set; }
        public System.DateTime underwrite_obd { get; set; }
        public string pif_nola { get; set; }
        public string subject_category_1 { get; set; }
        public string subject_category_2 { get; set; }
        public string ps_type { get; set; }
        public string comment { get; set; }
        public int spc_number { get; set; }
        public string season_nola { get; set; }
        public string re_up { get; set; }
        public decimal nffs_amount_funded { get; set; }
        public string funding_record_type { get; set; }
        public string nebulous { get; set; }
    }
}
