using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class StudentController : Controller
    {
        private SchoolDbContext _context;
         
        public StudentController(SchoolDbContext context) {
        
            _context = context;
        }

        [HttpGet]
        public IActionResult  Index()
        {
            List<Student> stList = _context.Students.ToList();
            return View( stList  );
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(obj); 
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
