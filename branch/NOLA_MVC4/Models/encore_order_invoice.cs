using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_order_invoice
    {
        public string borrower_ship_code { get; set; }
        public string customer_number { get; set; }
        public string contact { get; set; }
        public int order_number { get; set; }
        public System.DateTime date_entered { get; set; }
        public int invoice_number { get; set; }
        public string nola { get; set; }
        public int program_length { get; set; }
        public string series_title { get; set; }
        public double price { get; set; }
        public string extra_fee_type { get; set; }
        public double extra_fee_amount { get; set; }
    }
}
