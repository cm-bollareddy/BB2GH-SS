using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NOLA_MVC4.Models;
using OneLoginSAMLToolkit.Saml;
using OneLoginSAMLToolkit;
using System.Web.Security;
using WebMatrix.WebData;
using ComponentSpace.SAML2;
using System.Configuration;

namespace NOLA_MVC4.Controllers
{
    public class HomeController : Controller
    {
        public const string AttributesSessionKey = "";
        private pdbnolaContext db = new pdbnolaContext();
        public ActionResult Index()
        {
            
            bool csIsSSO = SAMLServiceProvider.IsSSO();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. " + csIsSSO.ToString();
            return View();
        }

        public ActionResult About()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult About(string nolaSearchString, string titleSearchString)
        {

            return PartialView("_archiveResults");
        }

        public ActionResult archiveDetails(string nolaCode)
        {
            ViewBag.errorText = "";
            if (String.IsNullOrEmpty(nolaCode))
            {
                ViewBag.errorText = "NOLA code was not supplied";
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            AccountSettings accountSettings = new AccountSettings();

            AuthRequest req = new AuthRequest(new AppSettings(), accountSettings);
            string partnerIdP = ConfigurationSettings.AppSettings["PartnerIdP"]; ;
            SAMLServiceProvider.InitiateSSO(Response, null, partnerIdP);
            //Response.Redirect(accountSettings.idp_sso_target_url + "?SAMLRequest=" + Server.UrlEncode(req.GetRequest(AuthRequest.AuthRequestFormat.Base64)));
            return View();
        }

        //
        // POST: /Account/LogOff

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //WebSecurity.Logout();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Consume()
        {
            bool isInResponseTo = false;
            string partnerIdP = null;
            string userName = null;
            IDictionary<string, string> attributes = null;
            string targetUrl = null;
            // replace with an instance of the users account.
            //AccountSettings accountSettings = new AccountSettings();

            //Response samlResponse = new Response(accountSettings);
            //samlResponse.LoadXmlFromBase64(Request.Form["SAMLResponse"]);

            //if (samlResponse.IsValid())
            //{
            //    var Text = samlResponse.GetNameID();
            //    FormsAuthentication.RedirectFromLoginPage(samlResponse.GetNameID(), false);
            //}
            //else
            //{
            //    Response.Write("Failed");
            //}
            try
            {

                SAMLServiceProvider.ReceiveSSO(Request, out isInResponseTo, out partnerIdP, out userName, out attributes, out targetUrl);
                FormsAuthentication.RedirectFromLoginPage(userName, false);
                
                // Save the attributes.
                Session[AttributesSessionKey] = attributes;
            }
            catch (ComponentSpace.SAML2.Exceptions.SAMLException e)
            {
                throw e;
            }
            if (targetUrl == null)
            {
                targetUrl = "~/";
            }

            return RedirectToLocal(targetUrl);
        }
        #region Helpers
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion

    }
}
