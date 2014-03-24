using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_order_header
    {
        public int order_number { get; set; }
        public string order_status { get; set; }
        public string borrower_ship_code { get; set; }
        public string borrower_ship_dept { get; set; }
        public System.DateTime date_entered { get; set; }
        public string invoice_number { get; set; }
        public System.DateTime invoice_date { get; set; }
        public string comments { get; set; }
    }
}
