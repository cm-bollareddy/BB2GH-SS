using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_customer_view1
    {
        public System.DateTime date_entered { get; set; }
        public string borrower_ship_code { get; set; }
        public double price { get; set; }
        public double tech_fee { get; set; }
        public double license_fee { get; set; }
        public double cancel_fee { get; set; }
    }
}
