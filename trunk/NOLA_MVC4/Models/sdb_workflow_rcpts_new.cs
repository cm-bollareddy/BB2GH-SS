using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_workflow_rcpts_new
    {
        public int rcpt_id { get; set; }
        public int bv_id { get; set; }
        public string tab_type { get; set; }
        public string username { get; set; }
        public string is_pbs { get; set; }
        public string is_approver { get; set; }
    }
}
