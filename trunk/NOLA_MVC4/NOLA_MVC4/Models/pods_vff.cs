using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods_vff
    {
        public string version_nola { get; set; }
        public string flag_type { get; set; }
        public int flag_begins { get; set; }
        public System.DateTime daily_timestamp { get; set; }
        public string operation { get; set; }
    }
}
