using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_shelves
    {
        public int shelf_number { get; set; }
        public short rack { get; set; }
        public short shelf { get; set; }
        public short space { get; set; }
        public Nullable<int> control_number { get; set; }
        public string tape_size { get; set; }
        public string location { get; set; }
    }
}
