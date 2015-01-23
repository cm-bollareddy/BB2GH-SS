using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NOLA_MVC4.Models;
using NOLA_MVC4.ViewModels;
using NOLA_MVC4.Helpers;

namespace NOLA_MVC4.Controllers
{
    [Authorize]
    public class NOLAController : Controller
    {
        //
        // GET: /NOLA/
        private ProgramModelService _services = new ProgramModelService();
        private ParseNola _nolaFunctions = new ParseNola();
        //private pdbnolaContext db = new pdbnolaContext();
        public ActionResult Index(string nolaSearchString, string titleSearchString, int page = 1, string sort = "nola", string sortDir = "ASC")
        {
            var data = new NOLAProgramViewModel();
            const int programPerPage = 20;
            string sFormattedNola = null;
            string sStatusMessage = null;
            bool bGoodNola = false;
            Direction direction = (Direction)Enum.Parse(typeof(Direction), sortDir);

            var validColumns = new[] { "nola", "series_title", "program_title", "episode_title" };
            if (!validColumns.Any(c => c.Equals(sort, StringComparison.CurrentCultureIgnoreCase)))
                sort = "nola";

            ViewBag.Message = "NOLA Program Archives is your window into the program archives, " +
                "containing information on programs before the launch of BroadView. Enter the " +
                "partial NOLA code or Title for the program you wish to search to view all versions " +
                "for the program. Specifying an episode nola will return all versions for the episode. " +
                "Specifying a version nola will return the version. Clicking on a column header will " +
                "sort the results in ascending or descending order. From the Search Results, select " +
                "a NOLA to view the details for the selected version. ";

            if (Request.IsAjaxRequest())
            {
                if (!String.IsNullOrEmpty(nolaSearchString))
                {
                    bGoodNola = _nolaFunctions.util_validate_nola_root(nolaSearchString, ref sFormattedNola, ref sStatusMessage);
                    if (!bGoodNola)
                    {
                        bGoodNola = _nolaFunctions.Util_Parse_Nola(nolaSearchString, ref sFormattedNola, ref sStatusMessage);
                    }
                    if (bGoodNola)
                    {
                        //these functions were copied AS IS - you have to use a TRIM after you run it through the parse
                        //odd but there you go
                        var numPrograms = _services.countFilteredPrograms(p => p.nola.Contains(sFormattedNola.Trim()));
                        var programs = _services.GetProgramPage(
                            page,
                            programPerPage,
                            "it." + sort + " " + sortDir,
                            "nola.Contains(@0)", sFormattedNola.Trim()
                        );
                        data = new NOLAProgramViewModel()
                        {
                            NumberOfPrograms = numPrograms,
                            ProgramsPerPage = programPerPage,
                            Programs = programs,
                            nolaSearchString = sFormattedNola
                        };
                    }
                }
                else if (!String.IsNullOrEmpty(titleSearchString))
                {
                    var numPrograms = _services.countFilteredPrograms(p => p.program_title.Contains(titleSearchString)
                        || p.series_title.Contains(titleSearchString)
                        || p.episode_title.Contains(titleSearchString));

                    var programs = _services.GetProgramPage(
                        page,
                        programPerPage,
                        "it." + sort + " " + sortDir,
                        "program_title.Contains(@0) || series_title.Contains(@0) || episode_title.Contains(@0)", titleSearchString
                    );

                    data = new NOLAProgramViewModel()
                    {
                        NumberOfPrograms = numPrograms,
                        ProgramsPerPage = programPerPage,
                        Programs = programs
                    };
                }
                

                //var query = from n in db.nola_programs
                //            select n;
                //if (!String.IsNullOrEmpty(nolaSearchString))
                //{
                //    query = query.Where(n => n.nola.Contains(nolaSearchString));
                //}
                //if (!String.IsNullOrEmpty(titleSearchString))
                //{
                //    query = query.Where(n => n.program_title.Contains(titleSearchString)
                //        || n.series_title.Contains(titleSearchString)
                //        || n.episode_title.Contains(titleSearchString));
                //}
                return PartialView("_archiveResults", data);
            }
            return View(data);
        }

        //[HttpPost]
        //public ActionResult Index(string nolaSearchString, string titleSearchString)
        //{
        //    var query = from n in db.nola_programs
        //                select n;
        //    if (!String.IsNullOrEmpty(nolaSearchString))
        //    {
        //        query = query.Where(n => n.nola.Contains(nolaSearchString));
        //    }
        //    if (!String.IsNullOrEmpty(titleSearchString))
        //    {
        //        query = query.Where(n => n.program_title.Contains(titleSearchString)
        //            || n.series_title.Contains(titleSearchString)
        //            || n.episode_title.Contains(titleSearchString));
        //    }

        //    return PartialView("_archiveResults", query.ToList());
        //}

        //public ActionResult archiveResults()
        //{
        //    return View();
        //}

        public ActionResult archiveDetails(string nolaCode)
        {
            ViewBag.errorText = "";
            nola_programs detailQuery = new nola_programs();
            if (String.IsNullOrEmpty(nolaCode))
            {
                ViewBag.errorText = "NOLA code was not supplied";
                return View(detailQuery);
            }
            detailQuery = _services.GetProgramDetails(nolaCode);
            if (detailQuery == null)
            {
                return HttpNotFound();
            }
            return View(detailQuery);
        }        
    }
}
