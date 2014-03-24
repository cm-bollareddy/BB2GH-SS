using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_workflow_transitions
    {
        public int transition_id { get; set; }
        public string tab_type { get; set; }
        public short beg_status { get; set; }
        public short end_status { get; set; }
        public string @class { get; set; }
        public short send_to { get; set; }
        public short template_id { get; set; }
        public string is_replyable { get; set; }
    }
}
