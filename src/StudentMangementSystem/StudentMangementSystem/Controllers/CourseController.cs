
using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Controllers
{
    public class CourseController : Controller
    {
        private static List<Course> courses = new()
        {
            new Course
            {
                Id = 1,
                CourseName = "Advanced Programming",
                CourseCode = "CSC4164",
                Credit = 3,
                Description = "This course covers advanced programming concepts and techniques."
            },
            new Course
            {
                Id = 2,
                CourseName = "Database Management",
                CourseCode = "CSC3210",
                Credit = 3,
                Description = "This course covers database design and management concepts."
            }
        };

        public IActionResult Index()
        {
            return View(courses);
        }

        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            course.Id = courses.Count == 0 ? 1 : courses.Max(c => c.Id) + 1;

            courses.Add(course);

            return RedirectToAction("Index");
        }

        public IActionResult EditCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
                return NotFound();

            return View(course);
        }

        [HttpPost]
        public IActionResult EditCourse(Course updatedCourse)
        {
            var course = courses.FirstOrDefault(
                c => c.Id == updatedCourse.Id);

            if (course == null)
                return NotFound();

            course.CourseName = updatedCourse.CourseName;
            course.CourseCode = updatedCourse.CourseCode;
            course.Credit = updatedCourse.Credit;

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
                return NotFound();

            courses.Remove(course);

            return RedirectToAction("Index");
        }
    }
}
