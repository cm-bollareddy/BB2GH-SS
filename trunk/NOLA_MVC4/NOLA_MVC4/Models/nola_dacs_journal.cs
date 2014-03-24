using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_dacs_journal
    {
        public System.DateTime date_generated { get; set; }
        public System.DateTime sched_date { get; set; }
        public string dacs_filename { get; set; }
        public string message_sent { get; set; }
    }
}
