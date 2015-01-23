using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class sdb_workflow_templates
    {
        public short template_id { get; set; }
        public string filename { get; set; }
        public string label { get; set; }
        public string description { get; set; }
    }
}
