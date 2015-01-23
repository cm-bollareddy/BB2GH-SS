using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_media_timecodes
    {
        public int parent_id { get; set; }
        public Nullable<short> start_tape_hours { get; set; }
        public Nullable<short> start_tape_minutes { get; set; }
        public Nullable<short> start_tape_seconds { get; set; }
        public Nullable<short> start_tape_frames { get; set; }
        public Nullable<short> start_prog_hours { get; set; }
        public Nullable<short> start_prog_minutes { get; set; }
        public Nullable<short> start_prog_seconds { get; set; }
        public Nullable<short> start_prog_frames { get; set; }
        public Nullable<short> end_prog_hours { get; set; }
        public Nullable<short> end_prog_minutes { get; set; }
        public Nullable<short> end_prog_seconds { get; set; }
        public Nullable<short> end_prog_frames { get; set; }
        public Nullable<short> end_tape_hours { get; set; }
        public Nullable<short> end_tape_minutes { get; set; }
        public Nullable<short> end_tape_seconds { get; set; }
        public Nullable<short> end_tape_frames { get; set; }
    }
}
