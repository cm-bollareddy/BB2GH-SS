using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_fp_status
    {
        public int parent_id { get; set; }
        public int request_id { get; set; }
        public short action { get; set; }
        public Nullable<short> status_code { get; set; }
        public System.DateTime request_start { get; set; }
        public Nullable<System.DateTime> last_checked { get; set; }
        public string user_id { get; set; }
    }
}
