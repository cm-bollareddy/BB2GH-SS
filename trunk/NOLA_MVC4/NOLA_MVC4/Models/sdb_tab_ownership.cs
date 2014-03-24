using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_tab_ownership
    {
        public int tab_id { get; set; }
        public string tab_type { get; set; }
        public string operating_group { get; set; }
        public short operating_unit { get; set; }
    }
}
