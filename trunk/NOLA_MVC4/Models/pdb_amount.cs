using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_amount
    {
        public string funder_code { get; set; }
        public string record_type { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public string season_nola { get; set; }
        public string season_re_up { get; set; }
        public string prod_acq_indicator { get; set; }
        public int amount_funded { get; set; }
        public int f_y_received { get; set; }
        public string fund_credit { get; set; }
        public System.DateTime credit_begin_date { get; set; }
        public System.DateTime credit_end_date { get; set; }
    }
}
