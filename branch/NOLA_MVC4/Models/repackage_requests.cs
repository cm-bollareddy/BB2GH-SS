using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class repackage_requests
    {
        public int request_number { get; set; }
        public string nola_code { get; set; }
        public string title { get; set; }
        public string episode_title { get; set; }
        public Nullable<int> original_ttime { get; set; }
        public string requested_by { get; set; }
        public Nullable<System.DateTime> date_requested { get; set; }
        public string request_type { get; set; }
        public Nullable<System.DateTime> prefeed_date { get; set; }
        public Nullable<System.DateTime> hardfeed_date { get; set; }
        public string closed_capt { get; set; }
        public string current_subscript { get; set; }
        public string new_subscript { get; set; }
        public string specific_changes { get; set; }
        public Nullable<System.DateTime> completed_by { get; set; }
        public string prod_instr_supplied { get; set; }
        public string prgm_supervision { get; set; }
        public string who_supervise { get; set; }
        public string screen_cass_req { get; set; }
        public Nullable<System.DateTime> date_screen_req { get; set; }
        public string prod_supplied_spot_reel { get; set; }
        public Nullable<System.DateTime> spot_arrival_date { get; set; }
        public string recipient { get; set; }
        public string replace_tapes { get; set; }
        public Nullable<System.DateTime> replace_arrv_date { get; set; }
        public string master { get; set; }
        public string backup { get; set; }
        public string cc_reformatting_req { get; set; }
        public string disposition { get; set; }
        public string billing_info { get; set; }
        public string comments { get; set; }
    }
}
