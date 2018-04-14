using System.Web.Mvc;
using System.Web.Routing;

namespace MyResume
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("Profile", "Profile", new { controller = "Home", action = "Profil" });
            routes.MapRoute("Resume", "Resume", new { controller = "Home", action = "Resume" });
            routes.MapRoute("Portfolio", "Portfolio", new { controller = "Home", action = "Portfolio" });
            routes.MapRoute("Blog", "Blog", new { controller = "Home", action = "Blog" });
            routes.MapRoute("Contact", "Contact", new { controller = "Home", action = "Contact" });

        }
    }
}
