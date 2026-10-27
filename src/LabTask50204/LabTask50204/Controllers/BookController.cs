
using Microsoft.AspNetCore.Mvc;
using LabTask50204.Models.Books;

namespace LabTask50204.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                return View("Create", book);
            }

            return View(book);
        }
    }
}
