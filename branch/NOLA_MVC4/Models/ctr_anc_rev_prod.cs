using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_anc_rev_prod
    {
        public int contract_number { get; set; }
        public string prod_contact_fname { get; set; }
        public string prod_contact_lname { get; set; }
        public string prod_address_1 { get; set; }
        public string prod_address_2 { get; set; }
        public string prod_address_3 { get; set; }
        public string prod_city { get; set; }
        public string prod_state { get; set; }
        public string prod_zip { get; set; }
        public string prod_voice_phone { get; set; }
        public string prod_voice_ext { get; set; }
    }
}
