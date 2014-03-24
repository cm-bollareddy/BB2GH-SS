using System;
using System.Collections.Generic;

namespace NOLA_MVC4.Models
{
    public partial class nola_program_package_id
    {
        public string nola { get; set; }
        public string nola_version { get; set; }
        public string version_revision { get; set; }
        public int pkg_id { get; set; }
        public int revision_number { get; set; }
        public string full_key { get; set; }
    }
}
