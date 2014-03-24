using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class contract_nolas
    {
        public int contract_number { get; set; }
        public string nola { get; set; }
        public string program_title { get; set; }
        public string soundex { get; set; }
    }
}
