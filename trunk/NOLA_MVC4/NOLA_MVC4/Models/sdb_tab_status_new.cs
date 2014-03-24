using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_tab_status_new
    {
        public int tab_id { get; set; }
        public string tab_type { get; set; }
        public int bv_id { get; set; }
        public string last_approved_by { get; set; }
        public short status { get; set; }
        public System.DateTime mod_date { get; set; }
        public string mod_user { get; set; }
        public System.DateTime last_approved_date { get; set; }
        public System.DateTime submission_date { get; set; }
    }
}
