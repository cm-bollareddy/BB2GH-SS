using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class ctr_program_commitments
    {
        public int contract_number { get; set; }
        public int pgm_cmt_key { get; set; }
        public string fund_name { get; set; }
        public int amount { get; set; }
        public int year { get; set; }
    }
}
