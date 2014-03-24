using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_other_ship
    {
        public string lico_ship_name { get; set; }
        public string contact { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string zip_plus_four { get; set; }
        public string phone_area { get; set; }
        public string phone_exchange { get; set; }
        public string phone_number { get; set; }
    }
}
