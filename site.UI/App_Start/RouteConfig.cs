
namespace site.UI
{
	using System.Web.Mvc;
	using System.Web.Routing;

	public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapMvcAttributeRoutes();
			routes.LowercaseUrls = true;
			routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

			routes.MapRoute(
				name: "article",
				url: "article/{id}/{title}",
				defaults: new {
					controller = "Home",
					action = "Description",
					id = UrlParameter.Optional
				});
		}
	}
}
