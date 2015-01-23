using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_role_val
    {
        public short role_id { get; set; }
        public string label { get; set; }
        public string description { get; set; }
        public short unit_type { get; set; }
    }
}
