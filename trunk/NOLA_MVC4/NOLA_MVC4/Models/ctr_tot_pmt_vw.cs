using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_tot_pmt_vw
    {
        public int contract_number { get; set; }
        public Nullable<int> total_payments { get; set; }
    }
}
