using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_tab_type_val
    {
        public string tab_type { get; set; }
        public string name { get; set; }
        public int interval { get; set; }
        public string is_deliverable { get; set; }
        public string required { get; set; }
        public string nola_type { get; set; }
        public string bench_date { get; set; }
        public string rcpt_tab_type { get; set; }
    }
}
