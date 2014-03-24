using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_tians
    {
        public int tian_number { get; set; }
        public System.DateTime date_entered { get; set; }
        public Nullable<int> control_number { get; set; }
        public string nola { get; set; }
        public string series_title { get; set; }
        public string series_title_soundex { get; set; }
        public string program_title { get; set; }
        public string program_title_soundex { get; set; }
        public Nullable<int> shelf_number { get; set; }
        public int length { get; set; }
        public string tape_size { get; set; }
        public string master_backup { get; set; }
        public string stereo { get; set; }
        public string dolby { get; set; }
        public string sap { get; set; }
        public System.DateTime air_date_1 { get; set; }
        public System.DateTime air_date_2 { get; set; }
        public System.DateTime air_date_3 { get; set; }
        public string air_flag_1 { get; set; }
        public string air_flag_2 { get; set; }
        public string air_flag_3 { get; set; }
        public string air_flag_desc_1 { get; set; }
        public string air_flag_desc_2 { get; set; }
        public string air_flag_desc_3 { get; set; }
        public string tin_technician { get; set; }
        public string tian_technician { get; set; }
        public string action_taken { get; set; }
        public string time_of_air_action { get; set; }
        public string pres_org { get; set; }
        public string presenter_contact { get; set; }
        public string pres_phone_area { get; set; }
        public string pres_phone_exchange { get; set; }
        public string pres_phone_number { get; set; }
        public string printed { get; set; }
    }
}
