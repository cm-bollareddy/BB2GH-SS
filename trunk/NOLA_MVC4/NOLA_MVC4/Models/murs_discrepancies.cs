using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class murs_discrepancies
    {
        public string nola { get; set; }
        public Nullable<int> total_length { get; set; }
        public int pdb_length { get; set; }
    }
}
