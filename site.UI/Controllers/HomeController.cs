

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


		// GET: Home
		public ActionResult Index()
        {
            return View(service.GetAll());
        }

		[Route("article/{title}")]
		public ActionResult Description(string title)
		{
			return View(service.Get(title));
		}
    }
}