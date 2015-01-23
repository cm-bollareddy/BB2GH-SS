using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_episode_promo_subcat
    {
        public int pdb_promo_subcat_key { get; set; }
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public short subject_category { get; set; }
        public short subject_category_type { get; set; }
    }
}
