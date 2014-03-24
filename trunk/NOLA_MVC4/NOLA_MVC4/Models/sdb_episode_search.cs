using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_episode_search
    {
        public string episode_nola_char { get; set; }
        public short promotion_status { get; set; }
        public string episode_title_caps { get; set; }
        public string episode_title_search_text { get; set; }
    }
}
