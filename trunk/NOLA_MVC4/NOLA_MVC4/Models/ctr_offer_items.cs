using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_offer_items
    {
        public int contract_number { get; set; }
        public int offer_items_key { get; set; }
        public string offer_item { get; set; }
        public string offer_prod_comment { get; set; }
        public string offer_contact { get; set; }
        public string offer_address { get; set; }
        public string offer_item_comment { get; set; }
    }
}
