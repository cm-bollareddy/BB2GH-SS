using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class contract_history
    {
        public int contract_number { get; set; }
        public int ctr_hist_key { get; set; }
        public string agreement_type { get; set; }
        public System.DateTime date_sent { get; set; }
        public System.DateTime date_executed { get; set; }
    }
}
