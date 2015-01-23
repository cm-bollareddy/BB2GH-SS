using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class view_Schedule_Archive
    {
        public string sched_id { get; set; }
        public System.DateTime sched_start { get; set; }
        public System.DateTime sched_end { get; set; }
        public int length { get; set; }
        public string @event { get; set; }
    }
}
