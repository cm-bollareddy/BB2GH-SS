using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_oac_item
    {
        public int item_id { get; set; }
        public int entity_id { get; set; }
        public string item { get; set; }
        public string description { get; set; }
        public string manufacturer { get; set; }
        public decimal offering_price { get; set; }
        public decimal shipping_price { get; set; }
        public decimal total_price { get; set; }
        public decimal production_cost { get; set; }
        public decimal shipping_cost { get; set; }
        public decimal admin_cost { get; set; }
        public decimal other_cost { get; set; }
        public string other_cost_description { get; set; }
    }
}
