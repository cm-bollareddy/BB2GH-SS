using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_pres_prod_copy
    {
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string primary_code { get; set; }
        public int producer_deficit { get; set; }
        public short promotion_status { get; set; }
    }
}
