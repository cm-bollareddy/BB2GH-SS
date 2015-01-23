using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_cast
    {
        public int cast_key { get; set; }
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public string fname { get; set; }
        public string fsoundex { get; set; }
        public string lname { get; set; }
        public string lsoundex { get; set; }
        public string suffix { get; set; }
        public string role { get; set; }
        public string cast_include_in_reports { get; set; }
        public string cast_description { get; set; }
    }
}
