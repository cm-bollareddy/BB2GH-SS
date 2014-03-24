using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_subcat
    {
        public int pdb_subcat_key { get; set; }
        public string episode_nola { get; set; }
        public string pif_nola { get; set; }
        public string subject_category { get; set; }
        public short promotion_status { get; set; }
    }
}
