
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

            List<Employee> empList = new List<Employee>();


            Employee emp1 = new Employee() { Id = 1012, Name = "Scott" };
            Employee emp2 = new Employee() { Id = 1013, Name = "Smith" };
            Employee emp3 = new Employee() { Id = 1014, Name = "Sandy" };
            

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            foreach (Employee emp in empList)
            {
                Console.WriteLine($"{emp.Id},{emp.Name}");
            }


        }
    }
}


