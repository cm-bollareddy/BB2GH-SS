using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_file_location_new
    {
        public int location_id { get; set; }
        public int tab_id { get; set; }
        public short file_type { get; set; }
        public int bv_id { get; set; }
        public string filename { get; set; }
        public string location { get; set; }
        public string tab_type { get; set; }
    }
}
