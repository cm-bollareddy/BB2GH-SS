using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods_vef
    {
        public string version_nola { get; set; }
        public int element_number { get; set; }
        public System.DateTime daily_timestamp { get; set; }
        public string operation { get; set; }
    }
}
