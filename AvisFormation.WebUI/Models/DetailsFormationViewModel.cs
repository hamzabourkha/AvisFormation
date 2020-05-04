using AvisFormations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvisFormations.WebUI.Models
{
    public class DetailsFormationViewModel
    {
        public string FormationName { get; set; }
        public string FormationSEO { get; set; }
        public string FormationDescription { get; set; }
        public List<Avis> FormationAvis { get; set; }
        public string FormationUrl { get; internal set; }
    }
}