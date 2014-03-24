using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class als_edge
    {
        public string unit_nola { get; set; }
        public string series_title { get; set; }
        public string program_title { get; set; }
        public string episode_title { get; set; }
        public string unit_type { get; set; }
        public System.DateTime production_date { get; set; }
        public System.DateTime availability_date { get; set; }
        public short length { get; set; }
        public string closed_caption { get; set; }
        public string stereo { get; set; }
        public string dolby { get; set; }
        public string colorbw { get; set; }
        public string sap3 { get; set; }
        public string sap4 { get; set; }
        public string flagged1 { get; set; }
        public string flagged2 { get; set; }
        public string open_dbs_flag { get; set; }
        public System.DateTime arrival_date_pds { get; set; }
        public string master_format { get; set; }
        public string master_comment { get; set; }
        public string program_group { get; set; }
        public string isbn_ { get; set; }
        public string distributors_code_curr { get; set; }
        public string distributor_name { get; set; }
        public string contact_name { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string address_3 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string extension { get; set; }
        public string alternate_phone { get; set; }
        public string alternate_extension { get; set; }
        public string fax { get; set; }
        public string original_distributor { get; set; }
        public string shipped_from_code { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string edition { get; set; }
        public string opid_last_updated { get; set; }
        public System.DateTime date_last_updated { get; set; }
    }
}
