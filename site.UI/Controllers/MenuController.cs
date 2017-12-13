
namespace site.UI.Controllers
{
	using Service;
	using System.Web.Mvc;

	public class MenuController : Controller
    {
		private readonly IArticleService service;

		public MenuController(IArticleService service)
		{
			this.service = service;
		}

		public ActionResult Index(int selectedId)
        {
			var globe = service.GetArticlesGlobe();
			globe.SelectedArticleId = selectedId;
			return PartialView(globe);
        }
    }
}