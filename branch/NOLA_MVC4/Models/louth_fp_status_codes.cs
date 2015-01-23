using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_fp_status_codes
    {
        public short system_id { get; set; }
        public short status_code { get; set; }
        public string status_code_name { get; set; }
        public string status_code_desc { get; set; }
        public string terminal { get; set; }
    }
}
