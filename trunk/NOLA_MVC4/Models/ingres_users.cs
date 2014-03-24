using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ingres_users
    {
        public string name { get; set; }
        public int status { get; set; }
        public int default_priv { get; set; }
        public System.DateTime expire_date { get; set; }
    }
}
