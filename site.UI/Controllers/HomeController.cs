

namespace site.UI.Controllers
{
	using Service;
	using System.Web.Mvc;

	public class HomeController : Controller
    {
		private readonly IArticleService service;

		public HomeController(IArticleService service)
		{
			this.service = service;
		}

		public ActionResult Index()
        {
            return View(service.GetArticlesGlobe());
        }

		[Route("article/{id}/{title}")]
		public ActionResult Description(int id)
		{
			var globe = service.GetArticlesGlobe();
			globe.SelectedArticleId = id;
			return View(service.Get(id));
		}
    }
}