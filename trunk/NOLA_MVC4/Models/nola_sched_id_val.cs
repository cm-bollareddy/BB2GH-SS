using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_sched_id_val
    {
        public string sched_id { get; set; }
        public string satellite { get; set; }
        public float frequency { get; set; }
        public int band_width { get; set; }
        public string band_type { get; set; }
        public string in_use { get; set; }
    }
}
