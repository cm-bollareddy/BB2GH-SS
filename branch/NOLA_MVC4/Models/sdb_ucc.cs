using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_ucc
    {
        public int ucc_id { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public int total_amount { get; set; }
        public int preamble_time { get; set; }
        public string preamble_video { get; set; }
        public string preamble_audio { get; set; }
    }
}
