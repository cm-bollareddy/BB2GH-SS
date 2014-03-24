using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_content_flag
    {
        public string episode_nola { get; set; }
        public string event_nola { get; set; }
        public string pif_nola { get; set; }
        public string flag_type { get; set; }
        public int flag_time { get; set; }
        public int flag_length { get; set; }
        public string flag_description { get; set; }
        public int content_flag_id { get; set; }
        public short promotion_status { get; set; }
    }
}
