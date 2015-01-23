using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class xponder_id_val
    {
        public string xponder_id { get; set; }
        public string satellite_code { get; set; }
        public float base_frequency { get; set; }
        public int bandwidth { get; set; }
        public string bandtype { get; set; }
        public string uscs_transponder_id { get; set; }
    }
}
