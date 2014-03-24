using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_reel_timecodes
    {
        public string event_nola { get; set; }
        public int reel_number { get; set; }
        public string mb { get; set; }
        public string not_for_air { get; set; }
        public Nullable<int> offset_to_first_second { get; set; }
        public Nullable<int> offset_to_last_second { get; set; }
        public Nullable<short> som_hh { get; set; }
        public Nullable<short> som_mm { get; set; }
        public Nullable<short> som_ss { get; set; }
        public Nullable<short> som_ff { get; set; }
        public Nullable<short> dur_hh { get; set; }
        public Nullable<short> dur_mm { get; set; }
        public Nullable<short> dur_ss { get; set; }
        public Nullable<short> dur_ff { get; set; }
        public Nullable<int> odetics_bar_code { get; set; }
        public Nullable<int> fireupdate { get; set; }
    }
}
