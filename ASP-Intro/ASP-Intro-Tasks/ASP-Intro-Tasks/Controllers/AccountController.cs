using Microsoft.AspNetCore.Mvc;

namespace ASP_Intro_Tasks.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<string>() { "Chinara", "Konul", "Roya", "Elekber", "Ibrahim", "Shaiq" };

            return View(users);
        }
    }
}
