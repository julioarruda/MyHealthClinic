using Microsoft.AspNetCore.Mvc;

namespace MyHealth.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Version = "1.0.0";
            return View();
        }

    }
}
