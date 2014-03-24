using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_pif_tab_due_date
    {
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string tab_type { get; set; }
        public string required { get; set; }
        public int due_interval { get; set; }
        public string bench_date { get; set; }
    }
}
