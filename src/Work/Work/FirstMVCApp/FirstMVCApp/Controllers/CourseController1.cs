using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    [Route("courses")]
    public class CourseController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Title = "All Courses";
            return View();
        }

        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.CourseId = id;
            return View();
        }

        [Route("search")]
        public IActionResult Search(string keyword)
        {
            ViewBag.Keyword = keyword;
            return View();
        }
    }
}