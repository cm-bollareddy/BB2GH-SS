using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class twr_to_sa_tapes
    {
        public string twr_number { get; set; }
        public string item_no { get; set; }
        public string mformat { get; set; }
        public int shelf_location { get; set; }
        public string xact_time { get; set; }
        public string operation { get; set; }
    }
}
