
using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentMangementSystem.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new()
        {
            new Student
            {
                Id = 1,
                Name = "Fahad Hasan",
                Email = "fahad@example.com",
                Phone = "01711111111",
                StudentCode = "ST001"
            },
            new Student
            {
                Id = 2,
                Name = "Alice Rahman",
                Email = "alice@example.com",
                Phone = "01722222222",
                StudentCode = "ST002"
            },
            new Student
            {
                Id = 3,
                Name = "John Doe",
                Email = "john@example.com",
                Phone = "01733333333",
                StudentCode = "ST003"
            }
        };

        // Display all students
        [HttpGet]
        public IActionResult GetStudent()
        {
            return View(students);
        }

        // Show Add Student form
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        //  Add a new student
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(Student student)
        {
            student.Id = students.Count == 0
                ? 1
                : students.Max(s => s.Id) + 1;

            students.Add(student);

            return RedirectToAction(nameof(GetStudent));
        }

        // Show existing student data
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        //  Save edited student data
        [HttpPost]
        public IActionResult EditStudent(Student updatedStudent)
        {
            var student = students.FirstOrDefault(
                s => s.Id == updatedStudent.Id);

            if (student == null)
                return NotFound();

            student.Name = updatedStudent.Name;
            student.Email = updatedStudent.Email;
            student.Phone = updatedStudent.Phone;
            student.StudentCode = updatedStudent.StudentCode;

            return RedirectToAction(nameof(GetStudent));
        }

        //  Delete a student
        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            students.Remove(student);

            return RedirectToAction(nameof(GetStudent));
        }
    }
}
