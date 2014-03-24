using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class lico_media
    {
        public int parent_id { get; set; }
        public short element_number { get; set; }
        public string res_type { get; set; }
        public string filename { get; set; }
        public System.DateTime create_date { get; set; }
    }
}
