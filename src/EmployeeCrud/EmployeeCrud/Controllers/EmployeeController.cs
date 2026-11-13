using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
