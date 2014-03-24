using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_order_tapes
    {
        public int order_number { get; set; }
        public string nola { get; set; }
        public int control_number { get; set; }
        public int shelf_number { get; set; }
        public int reel_number { get; set; }
        public string hold_report_name { get; set; }
        public string tapes_status { get; set; }
    }
}
