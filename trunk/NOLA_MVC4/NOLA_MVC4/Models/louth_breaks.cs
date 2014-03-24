using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_breaks
    {
        public string sched_id { get; set; }
        public string start_nola_root { get; set; }
        public Nullable<short> bug_start_offset_minutes { get; set; }
        public Nullable<short> bug_start_offset_seconds { get; set; }
        public Nullable<short> bug_start_offset_frames { get; set; }
        public Nullable<short> bug_end_offset_minutes { get; set; }
        public Nullable<short> bug_end_offset_seconds { get; set; }
        public Nullable<short> bug_end_offset_frames { get; set; }
        public string bug_gpi_name { get; set; }
    }
}
