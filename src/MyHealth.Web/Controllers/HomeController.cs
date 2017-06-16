using Microsoft.AspNetCore.Mvc;

namespace MyHealth.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Version = "2.0.0";
            return View();
        }

    }
}
