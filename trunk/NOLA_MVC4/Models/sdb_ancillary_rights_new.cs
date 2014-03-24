using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_ancillary_rights_new
    {
        public int rights_id { get; set; }
        public int dea_id { get; set; }
        public string type { get; set; }
        public string rights_available { get; set; }
        public string offered_on_air { get; set; }
        public string owner { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
    }
}
