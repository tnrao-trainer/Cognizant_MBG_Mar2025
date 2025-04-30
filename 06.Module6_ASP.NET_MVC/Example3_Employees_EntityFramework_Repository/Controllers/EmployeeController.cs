using Microsoft.AspNetCore.Mvc;
using WebApplication37.Models;
using WebApplication37.Repositories;

namespace WebApplication37.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo) {
            _repo = repo; 
        }
      
        public IActionResult Index()
        {
            List<Employee>  empList  =  _repo.GetAllEmployees();
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
                _repo.AddEmployee(obj); 
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }           
        }
    }
}
