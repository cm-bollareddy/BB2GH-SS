using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_oac_entity
    {
        public int entity_id { get; set; }
        public int oac_id { get; set; }
        public string offeror { get; set; }
        public string fe_name { get; set; }
        public string fe_address { get; set; }
        public string fe_city { get; set; }
        public string fe_state { get; set; }
        public string fe_zip { get; set; }
        public string message_audio { get; set; }
        public string message_video { get; set; }
        public string video_description { get; set; }
        public string offer_made_by { get; set; }
        public string payment_company { get; set; }
        public string payment_contact { get; set; }
        public string payment_address { get; set; }
        public string payment_city { get; set; }
        public string payment_state { get; set; }
        public string payment_zip { get; set; }
        public string payment_phone { get; set; }
        public string payment_fax { get; set; }
        public string payment_email { get; set; }
        public int message_length { get; set; }
        public string pre_pbs_logo { get; set; }
    }
}
