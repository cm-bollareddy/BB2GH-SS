using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_version
    {
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public string event_nola { get; set; }
        public string original_version { get; set; }
        public short version_length { get; set; }
        public string version_filler_cut { get; set; }
        public string version_rating { get; set; }
        public string version_subrating { get; set; }
        public string version_language_alert { get; set; }
        public string version_material_alert { get; set; }
        public string version_title { get; set; }
        public string version_comment { get; set; }
        public short version_filler_tot { get; set; }
        public string sub_description { get; set; }
        public int sub_time { get; set; }
        public string voca_indicator { get; set; }
        public int voca_start_time { get; set; }
        public short voca_length { get; set; }
        public string voca_why_not { get; set; }
        public string ind_description { get; set; }
        public int t_time { get; set; }
        public string completed_by { get; set; }
        public System.DateTime completed_date { get; set; }
        public short number_of_reels { get; set; }
        public string color_indicator { get; set; }
        public string captions { get; set; }
        public string caption_source { get; set; }
        public string language { get; set; }
        public string live_indicator { get; set; }
        public string orig_point { get; set; }
        public string uplink { get; set; }
        public string telco { get; set; }
        public string pbs_record { get; set; }
        public string tape_in_house { get; set; }
        public string stereo_mono { get; set; }
        public string dolby { get; set; }
        public string actimates { get; set; }
        public short resolution_type { get; set; }
        public string resolution_desc { get; set; }
        public string hdtv { get; set; }
        public string open_dvs { get; set; }
        public string sap_3_code { get; set; }
        public string sap_3_desc { get; set; }
        public string sap_4_code { get; set; }
        public string sap_4_desc { get; set; }
        public string sap_by_pbs { get; set; }
        public string dvi_by_pbs { get; set; }
        public string caption_provided_by_pbs { get; set; }
        public string dvi_provided_by_pbs { get; set; }
        public string version_available { get; set; }
        public System.DateTime availability_date { get; set; }
        public string master_tape_format { get; set; }
        public string fulfillment { get; set; }
        public short number_weeks_before_air { get; set; }
        public System.DateTime deliv_date { get; set; }
        public System.DateTime revised_date { get; set; }
        public System.DateTime waiver_date { get; set; }
        public string late_tape_waiver { get; set; }
        public string tech_contact_name { get; set; }
        public string tech_contact_phone { get; set; }
        public string edge_flag { get; set; }
        public string viewer_advisory { get; set; }
        public string anti_clutter { get; set; }
        public string actual_length_indicator { get; set; }
    }
}
