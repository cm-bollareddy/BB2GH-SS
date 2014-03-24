using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_rating_log_a
    {
        public string event_nola { get; set; }
        public int start_time { get; set; }
        public string state { get; set; }
        public System.DateTime timestamp { get; set; }
        public string version_rating { get; set; }
        public string version_subrating { get; set; }
        public short database_no { get; set; }
        public int transaction_id { get; set; }
        public int sequence_no { get; set; }
    }
}
