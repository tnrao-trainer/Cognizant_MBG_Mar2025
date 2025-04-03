using System;
using System.Collections.Generic;
using System.Linq; 

namespace ConsoleApp9
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public double Sal { get; set; }
        public int Deptno { get; set; }
    }
    class Program
    {        
        static List<Employee> GetEmployeesList()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee { EmpId = 1, Ename = "John", Job = "Manager", Sal = 5000, Deptno = 10 },
                new Employee { EmpId = 2, Ename = "Alice", Job = "Developer", Sal = 4000, Deptno = 20 },
                new Employee { EmpId = 3, Ename = "Bob", Job = "Manager", Sal = 5500, Deptno = 10 },
                new Employee { EmpId = 4, Ename = "Charlie", Job = "Clerk", Sal = 3000, Deptno = 30 }
            };


            return empList;
        }
        static void Main()
        {

            List<Employee>  empList = GetEmployeesList();

            var result1 = empList.Where(item => item.Job == "Manager");

            foreach (var emp in result1)
            {
                Console.WriteLine($"{emp.Ename}, {emp.Job}, {emp.Deptno}, {emp.Sal}");
            }

            Console.WriteLine("----------------------");

            var result2 = empList.OrderBy(item => item.Sal);

            foreach (var emp in result2)
            {
                Console.WriteLine($"{emp.Ename}, {emp.Job}, {emp.Deptno}, {emp.Sal}");
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Sum of All Employees Salaries: "+ empList.Sum(item => item.Sal));

            Console.WriteLine("-----------------------");

            Employee obj = empList.FirstOrDefault(item => item.EmpId == 2);

            if (obj != null)
            {
                Console.WriteLine($"{obj.EmpId}, {obj.Ename}, {obj.Job}, {obj.Deptno}, {obj.Sal}");
            }
            else
            {
                Console.WriteLine("Employee Id does not exists");
            }
            Console.ReadLine();
        }
    }
}
