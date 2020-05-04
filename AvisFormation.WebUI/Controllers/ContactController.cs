using AvisFormations.Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvisFormation.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EnvoyerEmail(string nom, string email, string message)
        {
            try
            {
                var mger = new EmailManager();
                mger.SendEmail(nom, message, email);
            }
            catch
            {
                return View("ErreurEnvoi");
            }
            return View("Merci");
        }
    }
}