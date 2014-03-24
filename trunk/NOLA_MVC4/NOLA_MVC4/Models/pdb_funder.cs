using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_funder
    {
        public string code { get; set; }
        public string name { get; set; }
        public string parent { get; set; }
        public string type { get; set; }
        public string @class { get; set; }
        public string addr1 { get; set; }
        public string addr2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string sales { get; set; }
        public int employees { get; set; }
        public int ad_budget { get; set; }
        public string officer { get; set; }
        public string contact_1 { get; set; }
        public string contact_2 { get; set; }
        public string ad_agency { get; set; }
        public string pr_agency { get; set; }
        public string comment { get; set; }
    }
}
