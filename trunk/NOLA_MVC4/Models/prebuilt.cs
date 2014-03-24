using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class prebuilt
    {
        public string prebuiltnola { get; set; }
        public System.DateTime start_dt { get; set; }
        public System.DateTime end_dt { get; set; }
        public string dow { get; set; }
        public string prog_start { get; set; }
        public string prog_end { get; set; }
        public int element_number { get; set; }
    }
}
