using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_hld_rpt_print
    {
        public int shelf_number { get; set; }
        public int control_number { get; set; }
        public int order_number { get; set; }
        public string mb { get; set; }
        public int reel_number { get; set; }
        public string nola { get; set; }
        public string series_title { get; set; }
        public string program_title { get; set; }
        public string sent_from { get; set; }
        public string send_to { get; set; }
        public System.DateTime required_date { get; set; }
        public System.DateTime send_to_by { get; set; }
        public string courier_code { get; set; }
        public string dubbed { get; set; }
    }
}
