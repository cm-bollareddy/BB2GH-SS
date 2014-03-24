using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class encore_confirmation
    {
        public string nola { get; set; }
        public string series_title { get; set; }
        public string program_title { get; set; }
        public int program_length { get; set; }
        public int max_reels { get; set; }
        public string mb { get; set; }
        public System.DateTime required_date { get; set; }
        public string sent_from { get; set; }
        public string send_to { get; set; }
        public System.DateTime send_to_by { get; set; }
        public double price { get; set; }
        public string fee_type { get; set; }
        public double fee_amount { get; set; }
        public string courier_code { get; set; }
    }
}
