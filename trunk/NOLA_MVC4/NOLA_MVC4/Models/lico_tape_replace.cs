using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_tape_replace
    {
        public int control_number { get; set; }
        public string nola { get; set; }
        public System.DateTime date_entered { get; set; }
        public System.DateTime date_archived { get; set; }
        public System.DateTime date_due_back { get; set; }
        public string mb { get; set; }
        public string tape_size { get; set; }
        public short reel_number { get; set; }
        public string borrower_ship_code { get; set; }
        public string borrower_ship_dept { get; set; }
        public string comments { get; set; }
    }
}
