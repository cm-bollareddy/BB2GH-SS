using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_twrs
    {
        public int twr_number { get; set; }
        public int twr_master { get; set; }
        public string twr_type { get; set; }
        public string master_clone { get; set; }
        public string caption_file_name_1 { get; set; }
        public string caption_file_name_2 { get; set; }
        public string caption_file_name_3 { get; set; }
        public System.DateTime date_required { get; set; }
        public int time_required { get; set; }
        public string sched_id { get; set; }
        public string entered_by { get; set; }
        public System.DateTime date_entered { get; set; }
        public string series_nola { get; set; }
        public string nola_display { get; set; }
        public int length { get; set; }
        public string series_title { get; set; }
        public string series_title_soundex { get; set; }
        public string program_title { get; set; }
        public string program_title_soundex { get; set; }
        public string instruction_code { get; set; }
        public string instructions { get; set; }
        public string technician_remarks { get; set; }
        public string scheduler_remarks { get; set; }
        public string completed_by { get; set; }
        public System.DateTime date_time_completed { get; set; }
        public decimal blanket_amount { get; set; }
        public string bill_rate_type { get; set; }
        public Nullable<int> bill_cost_center { get; set; }
        public string bill_customer_code { get; set; }
        public decimal bill_billing_amount { get; set; }
        public string bill_station { get; set; }
        public string bill_name { get; set; }
        public string bill_organization { get; set; }
        public string bill_address_1 { get; set; }
        public string bill_address_2 { get; set; }
        public string bill_city { get; set; }
        public string bill_state { get; set; }
        public string bill_zip { get; set; }
        public string bill_zip_plus_four { get; set; }
        public string bill_phone_area { get; set; }
        public string bill_phone_exchange { get; set; }
        public string bill_phone_number { get; set; }
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
        public string disp_library_notes { get; set; }
        public string printed { get; set; }
        public System.DateTime invoice_date { get; set; }
        public string invoice_number { get; set; }
    }
}
