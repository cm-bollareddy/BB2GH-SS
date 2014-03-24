using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class log_exceptions
    {
        public System.DateTime timestamp { get; set; }
        public int sequence_number { get; set; }
        public string record { get; set; }
        public int code { get; set; }
        public string exception { get; set; }
    }
}
