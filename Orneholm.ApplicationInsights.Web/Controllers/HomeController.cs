using System.Web.Mvc;

namespace Orneholm.ApplicationInsights.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculator()
        {
            return View();
        }
    }
}