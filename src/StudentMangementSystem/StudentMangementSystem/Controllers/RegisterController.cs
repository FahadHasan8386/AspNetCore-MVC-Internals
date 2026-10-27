using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            if (model.Age == null)
            {
                ViewBag.Message = "Please enter your age.";
                return View(model);
            }

            if (model.Gender == "Male" && model.Age < 21)
            {
                ViewBag.Message = "Male must be at least 21 years old.";
                return View(model);
            }

            if (model.Gender == "Female" && model.Age < 18)
            {
                ViewBag.Message = "Female must be at least 18 years old.";
                return View(model);
            }

            ViewBag.Message = "Registration successful!";

            return View(model);
        }
    }
}

