using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_unit_type_tab_map
    {
        public short unit_type { get; set; }
        public string tab_type { get; set; }
        public short status { get; set; }
        public short action_id { get; set; }
    }
}
