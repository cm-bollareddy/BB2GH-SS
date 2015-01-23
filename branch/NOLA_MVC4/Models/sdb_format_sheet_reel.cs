using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_format_sheet_reel
    {
        public int sheet_reel_id { get; set; }
        public short reel_number { get; set; }
        public int format_sheet_id { get; set; }
        public int reel_length { get; set; }
    }
}
