using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_pdb_pif
    {
        public int contract_number { get; set; }
        public int season_number { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string season_nola { get; set; }
    }
}
