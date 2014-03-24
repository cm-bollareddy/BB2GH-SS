using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_pif
    {
        public string pif_nola { get; set; }
        public string season_nola { get; set; }
        public string nola_root { get; set; }
        public string re_up { get; set; }
        public short promotion_status { get; set; }
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
        public string pif_wti1_text { get; set; }
        public string pif_wti2_text { get; set; }
        public string pbs_prog_mgmt_name { get; set; }
        public string pbs_prog_mgmt_phone { get; set; }
        public string pbs_prog_mgmt_email { get; set; }
        public string pbs_editorial_name { get; set; }
        public string pbs_editorial_email { get; set; }
        public string pbs_editorial_phone { get; set; }
        public string ssg { get; set; }
        public short service_type { get; set; }
        public string other_svc_type_desc { get; set; }
        public string operating_group { get; set; }
        public short operating_unit { get; set; }
        public string caption_source { get; set; }
        public string captions { get; set; }
        public string color_indicator { get; set; }
        public string dolby { get; set; }
        public string embedded_data { get; set; }
        public string episode_rating_same { get; set; }
        public string internal_break { get; set; }
        public string language { get; set; }
        public string live_indicator { get; set; }
        public string orig_point { get; set; }
        public string pbs_record { get; set; }
        public string promo_materials_online { get; set; }
        public string promo_materials_online_desc { get; set; }
        public string promo_contact_name { get; set; }
        public string promo_contact_phone { get; set; }
        public string promo_contact_email { get; set; }
        public int promo_length { get; set; }
        public string rights_comments { get; set; }
        public string sap_3_code { get; set; }
        public string sap_3_desc { get; set; }
        public string sap_4_code { get; set; }
        public string sap_4_desc { get; set; }
        public string stereo_mono { get; set; }
        public string telco { get; set; }
        public string uplink { get; set; }
        public string webmarkers_flag { get; set; }
        public string country_of_origin { get; set; }
        public string tech_contact_name { get; set; }
        public string tech_contact_phone { get; set; }
        public string tech_contact_email { get; set; }
        public string subtitles { get; set; }
        public string website_flag { get; set; }
        public string audio_language { get; set; }
        public string caption_language { get; set; }
        public string caption_pbs_bill_desc { get; set; }
        public string caption_pbs_coordinated { get; set; }
        public string caption_arrive_encoded { get; set; }
        public string caption_dub_desc { get; set; }
        public string sap_3_language { get; set; }
        public string sap_4_language { get; set; }
        public string local_under_competitors { get; set; }
        public string rating_varies { get; set; }
        public string bw_photo_supplier { get; set; }
        public string screen_cassette_supplier { get; set; }
        public string additional_video_supplier { get; set; }
        public string on_air_promo_supplier { get; set; }
        public string print_promo_supplier { get; set; }
        public System.DateTime pic_lock_date { get; set; }
        public string contact_organization_req { get; set; }
        public string contact_address_req { get; set; }
        public string contact_type_req { get; set; }
        public string contact_name_comp { get; set; }
        public string contact_organization { get; set; }
        public string contact_address { get; set; }
        public string contact_phone { get; set; }
        public string pres_contact_email { get; set; }
        public string pd_contact_organization_req { get; set; }
        public string pd_contact_address_req { get; set; }
        public string pd_contact_type_req { get; set; }
        public string pd_contact_name_comp { get; set; }
        public string pd_contact_organization { get; set; }
        public string pd_contact_address { get; set; }
        public string pd_contact_phone { get; set; }
        public string pd_contact_email { get; set; }
        public string pd_editorial_name { get; set; }
        public string pd_editorial_email { get; set; }
        public string pd_editorial_phone { get; set; }
        public string cp_contact_organization_req { get; set; }
        public string cp_contact_address_req { get; set; }
        public string cp_contact_type_req { get; set; }
        public string content_alert_language { get; set; }
        public string content_alert_material { get; set; }
        public string content_alert_language_desc { get; set; }
        public string content_alert_material_desc { get; set; }
        public string pif_title_caps { get; set; }
        public string pif_title_search_text { get; set; }
        public string underwriting_competitors { get; set; }
        public string national_underwriter { get; set; }
        public string underwriting_lang { get; set; }
        public string program_notes { get; set; }
        public string web_site_url { get; set; }
        public string licenses { get; set; }
        public string closed_markets { get; set; }
        public string offer_reference { get; set; }
        public string broadcast_history { get; set; }
        public string program_carriage { get; set; }
        public string pi_promo_description { get; set; }
    }
}