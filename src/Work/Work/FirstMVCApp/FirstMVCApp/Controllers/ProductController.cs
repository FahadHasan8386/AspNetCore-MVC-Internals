using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string category, int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;

            return View();
        }
    }
}