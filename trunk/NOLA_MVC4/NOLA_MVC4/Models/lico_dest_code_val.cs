using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_dest_code_val
    {
        public string borrower_ship_code { get; set; }
        public string borrower_ship_dept { get; set; }
        public string contact { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string zip_plus_four { get; set; }
        public string phone_area { get; set; }
        public string phone_exchange { get; set; }
        public string phone_number { get; set; }
        public int cost_center { get; set; }
        public string courier_name { get; set; }
        public string courier_number { get; set; }
        public string borrower_comment { get; set; }
        public string dacs_user_name { get; set; }
    }
}
