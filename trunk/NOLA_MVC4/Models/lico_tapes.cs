using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_tapes
    {
        public int control_number { get; set; }
        public Nullable<int> shelf_number { get; set; }
        public int odetics_bar_code { get; set; }
        public string nola { get; set; }
        public System.DateTime date_entered { get; set; }
        public string mb { get; set; }
        public string tape_size { get; set; }
        public short reel_number { get; set; }
        public string loc_umd { get; set; }
        public string location { get; set; }
        public string in_or_out { get; set; }
        public string borrower_ship_code { get; set; }
        public string borrower_ship_dept { get; set; }
        public string reason_borrowed { get; set; }
        public System.DateTime date_borrowed { get; set; }
        public System.DateTime date_due_back { get; set; }
        public System.DateTime date_returned { get; set; }
        public string not_for_air { get; set; }
        public string credit_producer { get; set; }
        public string comments { get; set; }
    }
}
