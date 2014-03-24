using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_variables
    {
        public string variable_name { get; set; }
        public Nullable<double> numeric_value { get; set; }
        public string char_value { get; set; }
        public string usage { get; set; }
    }
}
