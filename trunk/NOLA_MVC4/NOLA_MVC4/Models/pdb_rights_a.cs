using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_rights_a
    {
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string record_type { get; set; }
        public System.DateTime rights_end { get; set; }
        public System.DateTime rights_start { get; set; }
        public int window_number { get; set; }
        public string window_type { get; set; }
        public short database_no { get; set; }
        public int transaction_id { get; set; }
        public int sequence_no { get; set; }
    }
}
