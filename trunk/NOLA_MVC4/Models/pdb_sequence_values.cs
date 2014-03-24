using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class pdb_sequence_values
    {
        public string sequence_owner { get; set; }
        public string sequence_table { get; set; }
        public string sequence_column { get; set; }
        public int sequence_value { get; set; }
    }
}
