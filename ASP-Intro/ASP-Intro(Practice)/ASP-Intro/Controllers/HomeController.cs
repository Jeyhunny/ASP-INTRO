using Microsoft.AspNetCore.Mvc;

namespace ASP_Intro.Controllers
{
    public class HomeController :Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            return View(nums);
        }



        //public string GetName()
        //{
        //    return "Chinara";
        //}

        //public string Index()
        //{
        //    return GetName();
        //}

        //private string GetName()
        //{
        //    return "Cinare";
        //}

        //public string Index(int id)
        //{
        //    if (id == 0)
        //    {
        //        return "Chinara";
        //    }
        //    return "Chinara-" + id;
        //}
        //public string Detail(string slug,string text)
        //{
        //    return slug + " "+ text;
        //}
    }
}
