using Microsoft.AspNetCore.Mvc;
using WebApplication37.Models;

namespace WebApplication37.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> empList = new List<Employee>()
            {
                new Employee { Empno = 1001, Ename = "John Smith", Job = "Developer", Sal = 75000, Deptno = 10 },
                new Employee { Empno = 1002, Ename = "Mary Johnson", Job = "Manager", Sal = 85000, Deptno = 20 },
                new Employee { Empno = 1003, Ename = "James Brown", Job = "Analyst", Sal = 65000, Deptno = 10 },
                new Employee { Empno = 1004, Ename = "Lisa Davis", Job = "Designer", Sal = 70000, Deptno = 30 }
        };

        public IActionResult Index()
        {            

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
            empList.Add(obj);
            return RedirectToAction("Index");
        }
    }
}
