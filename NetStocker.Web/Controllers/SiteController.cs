using Microsoft.AspNetCore.Mvc;

namespace NetStocker.Web.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
