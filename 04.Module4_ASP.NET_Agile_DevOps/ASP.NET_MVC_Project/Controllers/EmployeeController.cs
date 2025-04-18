using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
