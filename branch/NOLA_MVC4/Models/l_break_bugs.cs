using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class l_break_bugs
    {
        public int break_bug_id { get; set; }
        public int bug_start_minutes { get; set; }
        public short bug_start_seconds { get; set; }
        public short bug_start_frames { get; set; }
        public int bug_end_minutes { get; set; }
        public short bug_end_seconds { get; set; }
        public short bug_end_frames { get; set; }
        public int bug_gpi_id { get; set; }
    }
}
