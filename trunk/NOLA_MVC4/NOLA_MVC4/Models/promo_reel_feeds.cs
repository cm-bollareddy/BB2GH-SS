using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class promo_reel_feeds
    {
        public int promo_reel_feeds_key { get; set; }
        public string promo_reel { get; set; }
        public System.DateTime feed_date { get; set; }
        public string feed_time { get; set; }
        public string sched_id { get; set; }
    }
}
