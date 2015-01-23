using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_twr_episodes
    {
        public int twr_number { get; set; }
        public string nola_code { get; set; }
        public string title { get; set; }
        public Nullable<int> control_number { get; set; }
    }
}
