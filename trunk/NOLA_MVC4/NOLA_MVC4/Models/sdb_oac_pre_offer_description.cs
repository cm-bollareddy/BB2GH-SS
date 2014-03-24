using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_oac_pre_offer_description
    {
        public int pre_offer_description_id { get; set; }
        public int entity_id { get; set; }
        public short description_id { get; set; }
        public string details { get; set; }
    }
}
