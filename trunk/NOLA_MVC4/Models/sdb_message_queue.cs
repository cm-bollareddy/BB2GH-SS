using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_message_queue
    {
        public int message_id { get; set; }
        public string sender_id { get; set; }
        public string sender_name { get; set; }
        public string subject { get; set; }
        public string is_replyable { get; set; }
        public string recipient_list { get; set; }
        public string body { get; set; }
    }
}
