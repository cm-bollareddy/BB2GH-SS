using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_season_search
    {
        public string season_nola_char { get; set; }
        public int series_year { get; set; }
        public string series_title_caps { get; set; }
        public string series_title_search_text { get; set; }
        public short promotion_status { get; set; }
    }
}
