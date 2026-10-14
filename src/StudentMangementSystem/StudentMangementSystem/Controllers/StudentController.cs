using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStudent()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "John Doe" },
                new Student { Id = 2, Name = "Jane Smith" },
                new Student { Id = 3, Name = "Michael Johnson" }
            };
            return View(students);
        }

        public IActionResult AddStudent()
        {
            return View();
        }
    }
}
