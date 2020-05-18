using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace lab3_1_new
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Dict",
                url: "{controller}/{action}",
                defaults: new { controller = "Default", action = "Index" }

            );

            //routes.MapRoute(
            //"Default", // Route name
            //"{siteType}", // URL with parameters
            //new { controller = "Default", action = "Index", id = "" }  // Parameter defaults
        //);
        }
    }
}
