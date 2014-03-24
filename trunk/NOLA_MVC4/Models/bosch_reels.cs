using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class bosch_reels
    {
        public int sched_index { get; set; }
        public short reel_number { get; set; }
        public string @event { get; set; }
        public int event_start_sec { get; set; }
        public int reel_start_sec { get; set; }
        public int reel_length_sec { get; set; }
        public int master_control_number { get; set; }
        public string master_tape_size { get; set; }
        public int backup_control_number { get; set; }
        public string backup_tape_size { get; set; }
        public string reel_comments { get; set; }
    }
}
