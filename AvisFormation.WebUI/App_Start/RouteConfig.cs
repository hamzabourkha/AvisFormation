﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AvisFormations.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "detailsformation",
                url: "formation/{nomSeo}",
                defaults: new { controller = "Formation", action = "DetailsFormation"}
            );
            routes.MapRoute(
                name: "touteslesformations",
                url: "toutes-les-formations",
                defaults: new { controller = "Formation", action = "ToutesLesFormations", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
