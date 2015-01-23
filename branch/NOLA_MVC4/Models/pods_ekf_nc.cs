using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods_ekf_nc
    {
        public string episode_nola { get; set; }
        public string keyword { get; set; }
        public Nullable<System.DateTime> daily_timestamp { get; set; }
        public string operation { get; set; }
    }
}
