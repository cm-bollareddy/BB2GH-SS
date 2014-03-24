using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class l3_dtmf_tones_save
    {
        public string dtmf_tone { get; set; }
        public string suffix { get; set; }
        public string sense { get; set; }
        public short seconds { get; set; }
        public short frames { get; set; }
        public short duration { get; set; }
    }
}
