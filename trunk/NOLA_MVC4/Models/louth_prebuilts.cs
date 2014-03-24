using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_prebuilts
    {
        public string prebuilt_root { get; set; }
        public string prebuilt_nola { get; set; }
        public System.DateTime start_dt { get; set; }
        public System.DateTime end_dt { get; set; }
        public string dow { get; set; }
        public string prog_start { get; set; }
        public string prog_end { get; set; }
        public int element_number { get; set; }
    }
}
