using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class accenture_log_changes
    {
        public System.DateTime timestamp { get; set; }
        public string tablename { get; set; }
        public string notice { get; set; }
    }
}
