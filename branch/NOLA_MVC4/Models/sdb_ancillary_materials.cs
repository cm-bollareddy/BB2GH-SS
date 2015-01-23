using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_ancillary_materials
    {
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string ancillary_nola { get; set; }
        public int ancillary_key { get; set; }
        public string season_nola { get; set; }
        public string product_type { get; set; }
        public string program_group { get; set; }
        public string title { get; set; }
        public string distributor_code { get; set; }
        public string contact_name { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string address_3 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string phone { get; set; }
        public string extension { get; set; }
        public string alt_phone { get; set; }
        public string alt_extension { get; set; }
        public string fax { get; set; }
        public decimal list_price { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string edition { get; set; }
        public string isbn { get; set; }
        public System.DateTime date_available { get; set; }
        public System.DateTime expiration_date { get; set; }
        public string description { get; set; }
        public short promotion_status { get; set; }
    }
}
