using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nick_offer
    {
        public int prod_offer_key { get; set; }
        public string episode_nola { get; set; }
        public string event_nola { get; set; }
        public string pif_nola { get; set; }
        public string product { get; set; }
        public short promotion_status { get; set; }
        public int product_start_time { get; set; }
        public string product_text { get; set; }
        public int product_length { get; set; }
    }
}
