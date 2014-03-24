using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_internet_addresses
    {
        public string recipient_last_name { get; set; }
        public string recipient_first_name { get; set; }
        public string recipient_organization { get; set; }
        public string internet_address { get; set; }
        public string document { get; set; }
    }
}
