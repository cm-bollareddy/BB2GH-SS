using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods_vpf
    {
        public string version_nola { get; set; }
        public string product_type { get; set; }
        public int offer_start_time { get; set; }
        public System.DateTime daily_timestamp { get; set; }
        public string operation { get; set; }
    }
}
