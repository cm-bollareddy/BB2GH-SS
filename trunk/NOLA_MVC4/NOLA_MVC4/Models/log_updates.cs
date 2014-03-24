using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class log_updates
    {
        public int sequence_number { get; set; }
        public string updater { get; set; }
        public System.DateTime timestamp { get; set; }
        public System.DateTime lu_timestamp { get; set; }
        public string location { get; set; }
        public short row_number { get; set; }
        public string error_code { get; set; }
        public string msg { get; set; }
    }
}
