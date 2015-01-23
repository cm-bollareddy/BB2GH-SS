using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_ratings_val_a
    {
        public string rating { get; set; }
        public string rating_desc { get; set; }
        public string subrating { get; set; }
        public string subrating_desc { get; set; }
        public short database_no { get; set; }
        public int transaction_id { get; set; }
        public int sequence_no { get; set; }
    }
}
