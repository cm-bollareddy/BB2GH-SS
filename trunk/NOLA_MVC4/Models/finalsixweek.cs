using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class finalsixweek
    {
        public int id { get; set; }
        public string event_nola { get; set; }
        public int control_number { get; set; }
        public System.DateTime air_date { get; set; }
        public int timecode_in { get; set; }
        public int timecode_out { get; set; }
        public string media_status { get; set; }
        public string ingest_status { get; set; }
        public string ingest_operator { get; set; }
        public System.DateTime ingest_date { get; set; }
        public string ingest_comments { get; set; }
        public short is_audio3 { get; set; }
        public short is_audio4 { get; set; }
        public string avid_mob_id { get; set; }
        public string event_description { get; set; }
        public int mediainventory { get; set; }
    }
}
