using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_tape_archive
    {
        public int control_number { get; set; }
        public Nullable<int> shelf_number { get; set; }
        public int odetics_bar_code { get; set; }
        public string nola { get; set; }
        public System.DateTime date_entered { get; set; }
        public System.DateTime date_archived { get; set; }
        public string mb { get; set; }
        public string tape_size { get; set; }
        public short reel_number { get; set; }
        public string credit_producer { get; set; }
        public string not_for_air { get; set; }
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
        public string payment_mode { get; set; }
        public string courier_name { get; set; }
        public string courier_number { get; set; }
        public int cost_center { get; set; }
        public string comments { get; set; }
    }
}
