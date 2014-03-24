using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_order_detail
    {
        public int order_number { get; set; }
        public string nola { get; set; }
        public string detail_type { get; set; }
        public string mb { get; set; }
        public int number_of_reels { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public System.DateTime required_date { get; set; }
        public string sent_from { get; set; }
        public string send_to { get; set; }
        public System.DateTime send_to_by { get; set; }
        public double price { get; set; }
        public string extra_fee_type { get; set; }
        public double extra_fee_amount { get; set; }
        public string courier_code { get; set; }
        public string dubbed { get; set; }
        public string hold_report_name { get; set; }
    }
}
