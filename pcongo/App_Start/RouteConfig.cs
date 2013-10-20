using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pcongo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home",
                "",
                new { controller = "User", action = "Index" });

            routes.MapRoute("Default",
                "{id}/{controller}/{action}",
                new { controller = "User", action = "Details" }

                );
        }
    }
}