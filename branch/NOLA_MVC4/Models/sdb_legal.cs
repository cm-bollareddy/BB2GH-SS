using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_legal
    {
        public int legal_id { get; set; }
        public string pif_nola { get; set; }
        public string re_up { get; set; }
        public short indemnify_type { get; set; }
        public string ins_carrier { get; set; }
        public string ins_representative { get; set; }
        public string source { get; set; }
        public System.DateTime ins_date { get; set; }
        public string name_of_acceptor { get; set; }
        public short entity_of_acceptor { get; set; }
        public string accepted { get; set; }
        public string paper_submission { get; set; }
    }
}
