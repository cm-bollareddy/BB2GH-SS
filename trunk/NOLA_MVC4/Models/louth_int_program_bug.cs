using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_int_program_bug
    {
        public string sched_id { get; set; }
        public short minutes { get; set; }
        public short seconds { get; set; }
        public short frames { get; set; }
        public short duration_minutes { get; set; }
        public short duration_seconds { get; set; }
        public short duration_frames { get; set; }
        public string gpi_or_logomotion { get; set; }
        public string logomotion_page_number { get; set; }
        public string logomotion_device_name { get; set; }
        public Nullable<int> bug_gpi_id { get; set; }
    }
}
