using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_ucc_detail
    {
        public int detail_id { get; set; }
        public int ucc_id { get; set; }
        public string funder_code { get; set; }
        public int time { get; set; }
        public string video { get; set; }
        public string audio { get; set; }
        public int amount { get; set; }
        public short order_id { get; set; }
    }
}
