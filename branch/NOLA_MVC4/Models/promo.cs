using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class promo
    {
        public int promo_key { get; set; }
        public string nola { get; set; }
        public string promo_id { get; set; }
        public int control_number { get; set; }
        public short cut_id { get; set; }
        public string promo_reel { get; set; }
        public short promo_cut { get; set; }
        public System.DateTime arrival_date { get; set; }
        public System.DateTime departure_date { get; set; }
        public string location { get; set; }
        public string producer_code { get; set; }
        public int length { get; set; }
        public string length_indicator { get; set; }
        public string tag { get; set; }
        public string reel_size { get; set; }
        public string tape_size { get; set; }
        public string outcue { get; set; }
        public string endcue { get; set; }
        public string tech_notes { get; set; }
        public string comment { get; set; }
        public string mention { get; set; }
        public string note { get; set; }
        public string stereo { get; set; }
        public string gen { get; set; }
    }
}
