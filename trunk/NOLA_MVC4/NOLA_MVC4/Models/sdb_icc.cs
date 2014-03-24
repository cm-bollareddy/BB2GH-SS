using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_icc
    {
        public int icc_id { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string on_air_announcement { get; set; }
        public string video { get; set; }
        public string audio { get; set; }
        public string etv_data { get; set; }
    }
}
