using AvisFormations.WebUI.Models;
using AvisFormations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvisFormations.WebUI.Controllers
{
    public class AvisController : Controller
    {
        // GET: Avis
        public ActionResult LaisserUnAvis(string nomSeo)
        {
            var vm = new LaisserUnAvisViewModel();
            using (var context = new AvisDBEntities())
            {
                var formation = context.Formation.FirstOrDefault(f => f.NomSeo == nomSeo);
                if (formation == null) return RedirectToAction("ToutesLesFormations","Formation");
                vm.FormationSeo = formation.NomSeo;
                vm.FormationName = formation.Nom;
            }
            return View(vm);
        }

        public ActionResult SaveComment(string nom, string description , string note,string nomSeo)
        {
            Avis avis = new Avis();
            avis.Nom = nom;
            avis.Description = description;
            double dnote = 0;
            if (!double.TryParse(note, out dnote))
                throw new Exception("cannot parse !");
            avis.Note = dnote;
            avis.DateAvis = DateTime.Now;
            
            
            using(var context = new AvisDBEntities())
            {
                var formation = context.Formation.FirstOrDefault(f => f.NomSeo == nomSeo);
                avis.Formation = formation;
                avis.IdFormation = formation.Id;
                avis.UserId = "1";
                context.Avis.Add(avis);
                context.SaveChanges();
            }
            return RedirectToAction("DetailsFormation", "Formation", new { nomSeo = nomSeo });
        }
    }
}