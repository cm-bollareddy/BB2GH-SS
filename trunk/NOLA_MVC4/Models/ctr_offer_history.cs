using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_offer_history
    {
        public int offer_history_key { get; set; }
        public int offer_items_key { get; set; }
        public System.DateTime oa_rev_rpt_received { get; set; }
        public int oa_revenue_received { get; set; }
        public string offer_source { get; set; }
    }
}
