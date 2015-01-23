using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_labels
    {
        public int control_number { get; set; }
        public string nola { get; set; }
        public string full_set { get; set; }
        public int shelf_number { get; set; }
        public string mb_code { get; set; }
        public string mb_description { get; set; }
        public string mb_label_color { get; set; }
    }
}
