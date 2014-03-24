using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class twr_instructions
    {
        public string username { get; set; }
        public string instruction_code { get; set; }
        public string rate_type { get; set; }
        public int rate_code { get; set; }
        public int quantifier { get; set; }
        public string instructions { get; set; }
    }
}
