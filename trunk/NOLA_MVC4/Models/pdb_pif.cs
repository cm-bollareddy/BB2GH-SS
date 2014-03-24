using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_pif
    {
        public string pif_nola { get; set; }
        public string season_nola { get; set; }
        public string nola_root { get; set; }
        public string re_up { get; set; }
        public int atot_fund { get; set; }
        public int ptot_fund { get; set; }
        public int atot_cost { get; set; }
        public int ptot_cost { get; set; }
        public int spc_number { get; set; }
        public string previously_broadcast { get; set; }
        public string previous_distributor { get; set; }
        public string pif_comment { get; set; }
        public string pbs_acceptor { get; set; }
        public string pif_title { get; set; }
        public string pif_wti { get; set; }
        public string pif_type { get; set; }
        public int num_episodes { get; set; }
        public int pif_length { get; set; }
        public string length_varies { get; set; }
        public System.DateTime pif_obdate { get; set; }
        public string pif_rating { get; set; }
        public string pif_subrating { get; set; }
        public int pif_funding { get; set; }
        public int spc_carriage { get; set; }
        public int spc_coverage { get; set; }
        public string producer_code { get; set; }
        public string minority_production { get; set; }
        public string pif_funder_comments { get; set; }
        public int num_episodes_calculator { get; set; }
        public string local_under { get; set; }
        public string local_under_contact { get; set; }
        public string local_under_phone { get; set; }
        public System.DateTime underwrite_obd { get; set; }
        public string contact_name_comp { get; set; }
        public string contact_organization { get; set; }
        public string contact_address { get; set; }
        public string contact_phone { get; set; }
        public string pd_contact_name_comp { get; set; }
        public string pd_contact_phone { get; set; }
        public string content_alert_language { get; set; }
        public string content_alert_material { get; set; }
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
        public string foreign_rights { get; set; }
        public string basic_cable { get; set; }
        public string canadian { get; set; }
        public string canadian_specify { get; set; }
        public string audio_visual { get; set; }
        public string audio_visual_license { get; set; }
        public string home_rights { get; set; }
        public string home_rights_license { get; set; }
        public string telecourse { get; set; }
        public string cassette { get; set; }
        public string cassette_phone { get; set; }
        public string home_distributor { get; set; }
        public string home_phone { get; set; }
        public string off_air { get; set; }
        public string off_air_phone { get; set; }
        public string restriction_applies { get; set; }
        public string original_distributor { get; set; }
        public string current_distributor { get; set; }
        public string pods_hold_flag { get; set; }
        public string pods_sent_flag { get; set; }
        public System.DateTime pods_date_sent { get; set; }
        public System.DateTime production_date { get; set; }
        public string pi_promo_description { get; set; }
    }
}
