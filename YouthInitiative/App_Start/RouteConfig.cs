using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YouthInitiative
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "webPosts", url: "WebPosts/Index", defaults: new { controller = "WebPosts", action = "Index" });


            routes.MapRoute(
                name: "videoUrls", url: "VideoUrls/Index", defaults: new { controller = "VideoUrls", action = "Index" });



            routes.MapRoute(
                name: "videoUrlsCreate", url: "VideoUrls/Create", defaults: new { controller = "VideoUrls", action = "Create" });


            routes.MapRoute(
    name: "returnToStateOne", url: "stateOne", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute(
    name: "webPostsCreate", url: "WebPosts/Create", defaults: new { controller = "WebPosts", action = "Create" });
            routes.MapRoute(
              name: "Default",
             url: "{*url}",
          defaults: new { controller = "Home", action = "Index" });
        }
    }
}
