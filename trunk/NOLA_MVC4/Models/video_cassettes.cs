using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class video_cassettes
    {
        public int program_number { get; set; }
        public Nullable<System.DateTime> date_in_house { get; set; }
        public Nullable<System.DateTime> date_returned { get; set; }
        public string department { get; set; }
        public string screener { get; set; }
        public string title { get; set; }
        public Nullable<int> half_no_reels { get; set; }
        public Nullable<int> half_no_copies { get; set; }
        public Nullable<int> threeq_no_reels { get; set; }
        public Nullable<int> threeq_no_copies { get; set; }
        public string other1_descript { get; set; }
        public Nullable<int> other1_no_reels { get; set; }
        public Nullable<int> other1_no_copies { get; set; }
        public string other2_descript { get; set; }
        public Nullable<int> other2_no_reels { get; set; }
        public Nullable<int> other2_no_copies { get; set; }
        public string contact_name { get; set; }
        public string contact_company { get; set; }
        public string contact_address { get; set; }
        public Nullable<double> contact_phone { get; set; }
        public string disposition { get; set; }
        public string disposition_other { get; set; }
        public string comments { get; set; }
    }
}
