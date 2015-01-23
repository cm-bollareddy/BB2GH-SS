using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_rep_zero_barcodes
    {
        public int sequence_number { get; set; }
        public string action { get; set; }
        public string type { get; set; }
        public int parent_id { get; set; }
        public int element_number { get; set; }
        public string labeltitle { get; set; }
        public string userstr { get; set; }
        public short soma { get; set; }
        public short somb { get; set; }
        public short somc { get; set; }
        public short somd { get; set; }
        public short dura { get; set; }
        public short durb { get; set; }
        public short durc { get; set; }
        public short durd { get; set; }
        public int boxid { get; set; }
    }
}
