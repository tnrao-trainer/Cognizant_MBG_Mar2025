using System;
 

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


            var q1 = from item in empList
                     where item.Deptno == 10    
                     orderby item.Sal
                     select item;

            foreach (var emp in q1) {
                Console.WriteLine($"{emp.Ename}, {emp.Deptno}, {emp.Sal}");
            }


            Console.ReadLine();
        }
    }
}
