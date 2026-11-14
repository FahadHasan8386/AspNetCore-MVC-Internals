using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ExcellenceAward()
        {
            // LINQ query filtering eligible employees
            var eligibleEmployees = _context.Employees
                .Where(e => e.PerformanceScore >= 4.5 &&
                            e.LowestProjectRating > 3.7 &&
                            e.TotalProjectsCompleted >= 6)
                .ToList();

            return View(eligibleEmployees);
        }
    }
}
