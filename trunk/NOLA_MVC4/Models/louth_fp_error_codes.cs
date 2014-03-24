using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_fp_error_codes
    {
        public short system_id { get; set; }
        public short error_code { get; set; }
        public string error_code_name { get; set; }
        public string error_code_desc { get; set; }
    }
}
