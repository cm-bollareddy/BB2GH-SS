using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class catval_a
    {
        public string cv_code { get; set; }
        public string cv_desc { get; set; }
        public short database_no { get; set; }
        public int transaction_id { get; set; }
        public int sequence_no { get; set; }
    }
}
