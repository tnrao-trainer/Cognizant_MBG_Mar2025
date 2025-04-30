using Microsoft.AspNetCore.Mvc;
using WebApplication37.Models;

namespace WebApplication37.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context) {
            _context = context; 
        }
      

        public IActionResult Index()
        {
            List<Employee>  empList  =  _context.Employees.ToList();
            return View(empList);
        }

        [HttpGet]
        public IActionResult  Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

           
        }
    }
}
