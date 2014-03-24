using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_distributor_val
    {
        public string distributor { get; set; }
        public int distributor_group { get; set; }
        public string distributor_rpt_trans { get; set; }
        public string distributor_name { get; set; }
        public string distributor_status { get; set; }
        public short operating_unit { get; set; }
        public string subdistributor_flag { get; set; }
        public string logo_location { get; set; }
    }
}
