using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class contracts_bck
    {
        public int contract_number { get; set; }
        public System.DateTime date_created { get; set; }
        public string pba_contact_code { get; set; }
        public System.DateTime obd { get; set; }
        public string reporting_complete { get; set; }
        public string outstanding_payments { get; set; }
        public string season_description { get; set; }
        public int num_episodes { get; set; }
        public string focus_code { get; set; }
        public string funding_area { get; set; }
        public string program_title { get; set; }
        public string season_number { get; set; }
        public string nola { get; set; }
        public string lic_name { get; set; }
        public string lic_address_1 { get; set; }
        public string lic_address_2 { get; set; }
        public string lic_address_3 { get; set; }
        public string lic_city { get; set; }
        public string lic_state { get; set; }
        public string lic_zip { get; set; }
        public string lic_email { get; set; }
        public string lic_country { get; set; }
        public string lic_fax { get; set; }
        public string lic_voice_phone { get; set; }
        public string lic_voice_ext { get; set; }
        public string ptv_unlimited { get; set; }
        public int num_ptv_releases { get; set; }
        public int num_ptv_rlse_term { get; set; }
        public int num_ptv_rlse_term_ymdh { get; set; }
        public string ptv_perpetuity { get; set; }
        public string sch_off_air_record { get; set; }
        public int sch_off_air_term { get; set; }
        public int sch_off_air_term_ymdh { get; set; }
        public int sch_off_air_eb_ob { get; set; }
        public string canadian_holdback { get; set; }
        public int canadian_holdback_term { get; set; }
        public int can_holdback_term_ymdh { get; set; }
        public string dbs { get; set; }
        public string dbs_comment { get; set; }
        public string online { get; set; }
        public int online_term { get; set; }
        public int online_term_ymdh { get; set; }
        public int online_excl_nonexcl { get; set; }
        public string online_adv_promo { get; set; }
        public string online_cd_rom { get; set; }
        public int online_int_nonint { get; set; }
        public string online_text { get; set; }
        public string audio_visual { get; set; }
        public string audio_visual_text { get; set; }
        public string av_broad_lic_area { get; set; }
        public string av_comment { get; set; }
        public string retail_home_video { get; set; }
        public string retail_home_video_text { get; set; }
        public string rt_hv_broad_lic_area { get; set; }
        public string rt_hv_comment { get; set; }
        public string direct_response { get; set; }
        public string direct_response_text { get; set; }
        public string dr_broad_lic_area { get; set; }
        public string dr_comment { get; set; }
        public string on_air_offer { get; set; }
        public string ancillary_revenue { get; set; }
        public int anc_rev_percentage { get; set; }
        public int anc_percent_of_roi { get; set; }
        public string anc_address_same_as_prod { get; set; }
        public string anc_report_due { get; set; }
        public string step_up_payments { get; set; }
        public string first_dollar_gross { get; set; }
        public string adjusted_gross { get; set; }
        public string net { get; set; }
        public string sharing_other { get; set; }
        public string all_revenues { get; set; }
        public string program_sales_only { get; set; }
        public string program_related_sales { get; set; }
        public string revenue_other { get; set; }
        public string in_flight { get; set; }
        public string in_flight_reversion { get; set; }
        public string foreign_rights { get; set; }
        public string commercial_cable { get; set; }
        public string underwriting { get; set; }
        public string merchandise { get; set; }
        public string books { get; set; }
        public string hdtv { get; set; }
        public string spanish_language { get; set; }
        public int total_budget { get; set; }
        public int final_budget { get; set; }
        public string sharing_comment { get; set; }
        public string revenue_comment { get; set; }
    }
}
