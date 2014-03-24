using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_logos
    {
        public int louth_logos_key { get; set; }
        public string version_nola { get; set; }
        public int reel_number { get; set; }
        public int parent_id { get; set; }
        public short logo_som_hh { get; set; }
        public short logo_som_mm { get; set; }
        public short logo_som_ss { get; set; }
        public short logo_som_ff { get; set; }
        public short logo_dur_hh { get; set; }
        public short logo_dur_mm { get; set; }
        public short logo_dur_ss { get; set; }
        public short logo_dur_ff { get; set; }
    }
}
