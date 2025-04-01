using System.Collections.Generic;

namespace ConsoleApp3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>()
            {
                new Employee() { Id = 1012, Name = "Scott" },
                new Employee() { Id = 1013, Name = "Smith" },
                new Employee() { Id = 1014, Name = "Sandy" }
            };
                

            foreach (Employee emp in empList)
            {
                Console.WriteLine($"{emp.Id},{emp.Name}");
            }


        }
    }
}
