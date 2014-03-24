using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class contract_payments_bck
    {
        public int contract_number { get; set; }
        public int ctr_pmt_key { get; set; }
        public string payment_type { get; set; }
        public int payment_amount { get; set; }
        public System.DateTime payment_sent { get; set; }
    }
}
