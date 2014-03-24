using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_icc_detail
    {
        public int detail_id { get; set; }
        public int icc_id { get; set; }
        public string info_text { get; set; }
        public string url { get; set; }
    }
}
