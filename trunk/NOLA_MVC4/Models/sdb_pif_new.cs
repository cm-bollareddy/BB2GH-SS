using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_pif_new
    {
        public int dea_id { get; set; }
        public string previously_broadcast { get; set; }
        public string previous_distributor { get; set; }
        public string pbs_acceptor { get; set; }
        public string pif_wti { get; set; }
        public string pif_wti1_text { get; set; }
        public string pbs_prog_mgmt_name { get; set; }
        public string pbs_prog_mgmt_phone { get; set; }
        public string pbs_prog_mgmt_email { get; set; }
        public string pbs_editorial_name { get; set; }
        public string pbs_editorial_email { get; set; }
        public string pbs_editorial_phone { get; set; }
        public string embedded_data { get; set; }
        public string promo_materials_online { get; set; }
        public string promo_materials_online_desc { get; set; }
        public string webmarkers_flag { get; set; }
        public string website_flag { get; set; }
        public string contact_organization_req { get; set; }
        public string contact_address_req { get; set; }
        public int contact_type_req { get; set; }
        public string pd_contact_organization_req { get; set; }
        public string pd_contact_address_req { get; set; }
        public int pd_contact_type_req { get; set; }
        public string cp_contact_organization_req { get; set; }
        public string cp_contact_address_req { get; set; }
        public int cp_contact_type_req { get; set; }
        public string content_alert_language { get; set; }
        public string content_alert_material { get; set; }
        public string content_alert_language_desc { get; set; }
        public string content_alert_material_desc { get; set; }
    }
}
