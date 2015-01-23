using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class twr_to_sa
    {
        public int twr_number { get; set; }
        public string job_number { get; set; }
        public string subscript { get; set; }
        public System.DateTime due_date { get; set; }
        public System.DateTime next_air_date { get; set; }
        public string instructions { get; set; }
        public System.DateTime date_completed { get; set; }
        public int trt { get; set; }
        public string subscript_definition { get; set; }
        public string disp_station { get; set; }
        public string disp_name { get; set; }
        public string disp_organization { get; set; }
        public string disp_address_1 { get; set; }
        public string disp_address_2 { get; set; }
        public string disp_city { get; set; }
        public string disp_state { get; set; }
        public string disp_zip { get; set; }
        public string disp_zip_plus_four { get; set; }
        public string disp_phone_area { get; set; }
        public string disp_phone_exchange { get; set; }
        public string disp_phone_number { get; set; }
        public string remarks { get; set; }
        public System.DateTime xact_time { get; set; }
        public string operation { get; set; }
    }
}
