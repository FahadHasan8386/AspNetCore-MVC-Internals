using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> students = new()
        {
            new Student { Id = 1, Name = "Fahad Hasan" },
            new Student { Id = 2, Name = "Alice Rahman" },
            new Student { Id = 3, Name = "John Doe" },
            new Student { Id = 4, Name = "Jane Smith" },
            new Student { Id = 5, Name = "Michael Johnson" }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStudent()
        {
            return View(students);
        }

        public IActionResult AddStudent()
        {
             return View();
        }
    }
}
