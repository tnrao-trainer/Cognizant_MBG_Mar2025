using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication33.Pages
{
    public class StudentsModel : PageModel
    {
        public List<Student> Students { get; set; }

        public void OnGet()
        {
            // Mock data for demonstration
            Students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Alice Johnson", Age = 20, Course = "ASP.NET", Email = "alice@example.com" },
            new Student { StudentId = 2, Name = "Bob Smith", Age = 22, Course = "Angular", Email = "bob@example.com" },
            new Student { StudentId = 3, Name = "Charlie Brown", Age = 21, Course = "React", Email = "charlie@example.com" },
            new Student { StudentId = 4, Name = "Diana Prince", Age = 23, Course = "C#.NET", Email = "diana@example.com" }
        };
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }
            public string Email { get; set; }
        }
    }

}
