using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_anc_rev_sharing
    {
        public int contract_number { get; set; }
        public int ctr_anc_rev_key { get; set; }
        public System.DateTime rev_rpt_received { get; set; }
        public int revenue_received { get; set; }
        public int producer_recoup { get; set; }
    }
}
