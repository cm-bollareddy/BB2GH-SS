using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_borrow_return
    {
        public string nola { get; set; }
        public int control_number { get; set; }
        public short reel_number { get; set; }
        public string borrower_ship_code { get; set; }
        public string borrower_ship_dept { get; set; }
        public string reason_borrowed { get; set; }
        public string borrow_or_return { get; set; }
        public System.DateTime date_of_transaction { get; set; }
    }
}
