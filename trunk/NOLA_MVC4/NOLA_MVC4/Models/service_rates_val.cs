using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class service_rates_val
    {
        public int rate_code { get; set; }
        public string category { get; set; }
        public string service { get; set; }
        public Nullable<decimal> internal_rate_d { get; set; }
        public Nullable<decimal> ptv_sta_rate_f { get; set; }
        public Nullable<decimal> commercial_rate_c { get; set; }
        public string instructions { get; set; }
    }
}
