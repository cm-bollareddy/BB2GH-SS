using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NOLA_MVC4.Models;

namespace NOLA_MVC4.ViewModels
{
    public class NOLAProgramViewModel
    {
        public int NumberOfPrograms { get; set; }
        public IEnumerable<nola_programs> Programs { get; set; }
        public int ProgramsPerPage { get; set; }
        public string nolaSearchString { get; set; }
        public string titleSearchString { get; set; }
    }
}