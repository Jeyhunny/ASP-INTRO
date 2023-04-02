using Microsoft.AspNetCore.Mvc;

namespace ASP_Intro_Tasks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var nums = new List<int>();
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        nums.Add(i);
            //    }
            //}
            //return View(nums);

            int[] nums = { };
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Array.Resize(ref nums, nums.Length + 1);
                    nums[nums.Length - 1] = i;
                }
            }
            return View(nums);  
        }
    }
}
