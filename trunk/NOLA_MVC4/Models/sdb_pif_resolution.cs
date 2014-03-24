using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_pif_resolution
    {
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public short resolution_type { get; set; }
        public string resolution_desc { get; set; }
    }
}
