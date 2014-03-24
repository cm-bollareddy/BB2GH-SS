using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pbs_promos
    {
        public string promo_reel { get; set; }
        public short promo_cut { get; set; }
        public int promo_key { get; set; }
        public string nola { get; set; }
        public string promo_id { get; set; }
        public System.DateTime program_feed_date { get; set; }
        public string request { get; set; }
        public string revision { get; set; }
    }
}
