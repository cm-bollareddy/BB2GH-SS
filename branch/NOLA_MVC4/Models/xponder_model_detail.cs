using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class xponder_model_detail
    {
        public string xponder_id { get; set; }
        public string xponder_model { get; set; }
        public string sched_id { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public int carrier_percentage { get; set; }
    }
}
