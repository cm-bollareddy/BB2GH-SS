using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class l3_non_int_program_bug
    {
        public string sched_id { get; set; }
        public short minutes_from_rating { get; set; }
        public short seconds_from_rating { get; set; }
        public short frames_from_rating { get; set; }
        public short minutes_from_end { get; set; }
        public short seconds_from_end { get; set; }
        public short frames_from_end { get; set; }
        public string logomotion_device_name { get; set; }
        public string logomotion_page_number { get; set; }
        public short keyer_number { get; set; }
    }
}
