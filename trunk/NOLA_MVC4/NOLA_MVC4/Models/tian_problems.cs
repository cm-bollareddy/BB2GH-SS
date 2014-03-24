using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class tian_problems
    {
        public int tian_number { get; set; }
        public short category { get; set; }
        public int problem_number { get; set; }
        public string problem_type { get; set; }
        public string problem_description { get; set; }
    }
}
