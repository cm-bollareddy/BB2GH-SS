using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_season
    {
        public string season_nola { get; set; }
        public int num_of_pifs { get; set; }
        public System.DateTime obdate { get; set; }
        public int total_funding { get; set; }
        public int tot_prod_season_funding { get; set; }
        public int tot_acq_season_funding { get; set; }
        public int total_prod_funding { get; set; }
        public int total_acq_funding { get; set; }
        public string series_wti { get; set; }
        public string series_title { get; set; }
        public string x_flag { get; set; }
        public string pi_description { get; set; }
        public string series_wti1_text { get; set; }
        public string series_wti2_text { get; set; }
        public int series_year { get; set; }
        public string series_title_search_text { get; set; }
        public string series_title_caps { get; set; }
        public short promotion_status { get; set; }
    }
}
