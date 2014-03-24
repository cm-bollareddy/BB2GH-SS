using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_file_location
    {
        public int location_id { get; set; }
        public int tab_id { get; set; }
        public short file_type { get; set; }
        public string nola_code { get; set; }
        public string re_up { get; set; }
        public string filename { get; set; }
        public string location { get; set; }
        public string tab_type { get; set; }
    }
}
