using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class repackage_twr
    {
        public int request_number { get; set; }
        public int twr_number { get; set; }
        public Nullable<System.DateTime> date_completed { get; set; }
        public string technician { get; set; }
        public Nullable<int> new_ttime { get; set; }
    }
}
