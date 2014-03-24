using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class uscs_carrier_id_val
    {
        public string sched_id { get; set; }
        public string uplink { get; set; }
        public string carrier_id { get; set; }
        public int power { get; set; }
        public double eirp { get; set; }
    }
}
