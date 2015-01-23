using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class promo_library
    {
        public string sched_id { get; set; }
        public string promo_root { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public string nolachoice { get; set; }
        public int element_number { get; set; }
    }
}
