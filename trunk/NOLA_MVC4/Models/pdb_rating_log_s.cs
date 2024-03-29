using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_rating_log_s
    {
        public string event_nola { get; set; }
        public short database_no { get; set; }
        public int transaction_id { get; set; }
        public int sequence_no { get; set; }
        public Nullable<System.DateTime> trans_time { get; set; }
        public Nullable<System.DateTime> distribution_time { get; set; }
        public short in_archive { get; set; }
        public short dd_routing { get; set; }
        public short trans_type { get; set; }
        public short dd_priority { get; set; }
        public short new_key { get; set; }
        public short old_database_no { get; set; }
        public int old_transaction_id { get; set; }
        public int old_sequence_no { get; set; }
    }
}
