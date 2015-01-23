using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ad_techs
    {
        public int ad_tech_key { get; set; }
        public int discrepancy_number { get; set; }
        public string technician_name { get; set; }
        public string technician_assignment { get; set; }
    }
}
