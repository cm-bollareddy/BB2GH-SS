using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_program_view
    {
        public System.DateTime date_entered { get; set; }
        public string nola { get; set; }
        public string series_title { get; set; }
        public string send_to { get; set; }
        public int order_number { get; set; }
        public System.DateTime required_date { get; set; }
        public double price { get; set; }
        public double tech_fee { get; set; }
        public double license_fee { get; set; }
        public double cancel_fee { get; set; }
        public string borrower_ship_code { get; set; }
    }
}
