using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class twr_service_rates
    {
        public int twr_number { get; set; }
        public int rate_code { get; set; }
        public int multiplier { get; set; }
        public double length { get; set; }
    }
}
