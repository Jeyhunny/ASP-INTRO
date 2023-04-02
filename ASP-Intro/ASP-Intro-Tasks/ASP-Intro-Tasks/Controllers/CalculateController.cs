using Microsoft.AspNetCore.Mvc;

namespace ASP_Intro_Tasks.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            int a = 0;
            int b = 1;
            int[] fibNums = new int[10];
            fibNums[0] = a;
            fibNums[1] = b;
            for (int i = 2; i < 10; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                fibNums[i] = c;
            }
            return View(fibNums);
        }
    }
}
