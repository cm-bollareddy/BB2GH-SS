using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class louth_dtmf_cues
    {
        public string type { get; set; }
        public string onebefore { get; set; }
        public string twobefore { get; set; }
        public string justafter { get; set; }
        public short tonegroup { get; set; }
    }
}
