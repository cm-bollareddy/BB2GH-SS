using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_anc_rev_contact
    {
        public int contract_number { get; set; }
        public string contact_fname { get; set; }
        public string contact_lname { get; set; }
        public string contact_address_1 { get; set; }
        public string contact_address_2 { get; set; }
        public string contact_address_3 { get; set; }
        public string contact_city { get; set; }
        public string contact_state { get; set; }
        public string contact_zip { get; set; }
        public string contact_voice_phone { get; set; }
        public string contact_voice_ext { get; set; }
    }
}
