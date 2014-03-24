using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_anc_rpt_recoup_vw
    {
        public int contract_number { get; set; }
        public Nullable<System.DateTime> latest_report { get; set; }
        public Nullable<int> total_rev_received { get; set; }
        public Nullable<int> total_recoup { get; set; }
    }
}
