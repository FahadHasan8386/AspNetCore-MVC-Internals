
using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentMangementSystem.Controllers
{
    public class CourseController : Controller
    {
        private static List<Course> courses = new()
        {
            new Course
            {
                Id = 1,
                CourseCode = "CSC101",
                CourseName = "Introduction to Computer Science",
                Credit = 3,
                Description = "Basic computer science concepts"
            },
            new Course
            {
                Id = 2,
                CourseCode = "CSC201",
                CourseName = "Object Oriented Programming",
                Credit = 3,
                Description = "OOP concepts using C#"
            },
            new Course
            {
                Id = 3,
                CourseCode = "CSC301",
                CourseName = "Database Management System",
                Credit = 4,
                Description = "Database design and SQL"
            }
        };

        // Display all courses
        [HttpGet]
        public IActionResult GetCourse()
        {
            return View(courses);
        }

        // Show Add Course form
        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        // Add a new course
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View(course);
            }

            course.Id = courses.Count == 0
                ? 1
                : courses.Max(c => c.Id) + 1;

            courses.Add(course);

            return RedirectToAction(nameof(GetCourse));
        }

        // Show existing course data
        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        //  Save edited course data
        [HttpPost]
        public IActionResult EditCourse(Course updatedCourse)
        {
            if (!ModelState.IsValid)
            {
                return View(updatedCourse);
            }

            var course = courses.FirstOrDefault(
                c => c.Id == updatedCourse.Id);

            if (course == null)
            {
                return NotFound();
            }

            course.CourseCode = updatedCourse.CourseCode;
            course.CourseName = updatedCourse.CourseName;
            course.Credit = updatedCourse.Credit;
            course.Description = updatedCourse.Description;

            return RedirectToAction(nameof(GetCourse));
        }

        // Delete a course
        [HttpPost]
        public IActionResult DeleteCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            courses.Remove(course);

            return RedirectToAction(nameof(GetCourse));
        }
    }
}
