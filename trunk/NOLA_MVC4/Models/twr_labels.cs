using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class twr_labels
    {
        public int twr_number { get; set; }
        public string nola { get; set; }
        public string mb_code { get; set; }
        public string mb_description { get; set; }
        public string mb_label_color { get; set; }
        public short print_amount { get; set; }
        public string reel { get; set; }
        public string disp_name { get; set; }
    }
}
