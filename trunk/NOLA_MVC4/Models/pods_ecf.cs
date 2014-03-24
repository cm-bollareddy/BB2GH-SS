using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pods_ecf
    {
        public string ep_pif_nola { get; set; }
        public string cast_fname { get; set; }
        public string cast_lname { get; set; }
        public string cast_role { get; set; }
        public string pif_or_ep { get; set; }
        public System.DateTime daily_timestamp { get; set; }
        public string operation { get; set; }
    }
}
