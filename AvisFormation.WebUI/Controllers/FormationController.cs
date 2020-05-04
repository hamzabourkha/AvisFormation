using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvisFormations.WebUI.Models;
using AvisFormations.Data;

namespace AvisFormations.WebUI.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        public ActionResult ToutesLesFormations()
        {
            List<Formation> listFormations = new List<Formation>();
            using (var context = new AvisDBEntities())
            {
                listFormations = context.Formation.ToList();
            }
                return View(listFormations);
        }
        public ActionResult DetailsFormation(string nomSeo)
        {
            var vm = new DetailsFormationViewModel();
            using (var context = new AvisDBEntities())
            {
                var formation = context.Formation.FirstOrDefault(f => f.NomSeo == nomSeo);
                if (formation == null) return RedirectToAction("Index", "Home");
                vm.FormationName = formation.Nom;
                vm.FormationSEO = nomSeo;
                vm.FormationDescription = formation.Description;
                vm.FormationUrl = formation.Url;
                vm.FormationAvis = formation.Avis.ToList();
            }
            return View(vm);
        }

    }
}