using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_prog_techeval
    {
        public string nola { get; set; }
        public System.DateTime techeval_date { get; set; }
        public string technician { get; set; }
        public string techeval_comments { get; set; }
    }
}
