using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_pif_search
    {
        public string pif_nola_char { get; set; }
        public string re_up { get; set; }
        public short promotion_status { get; set; }
        public string season_nola_char { get; set; }
        public string nola_root { get; set; }
        public short operating_unit { get; set; }
        public string operating_group { get; set; }
        public string contact_organization { get; set; }
        public string pd_contact_organization { get; set; }
        public string pif_title_caps { get; set; }
        public string pif_title_search_text { get; set; }
        public System.DateTime pif_obdate { get; set; }
    }
}
