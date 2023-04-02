using Microsoft.AspNetCore.Mvc;

namespace ASP_Intro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
