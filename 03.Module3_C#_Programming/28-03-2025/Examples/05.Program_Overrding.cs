using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void PrintDetails()
        {
            System.Console.WriteLine("{0},{1},{2}", FirstName, LastName, Age);
        }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }
        public string Department { get; set; }


        public override void PrintDetails()
        {
            Console.WriteLine($"{FirstName}, {LastName}, {EmployeeId}, {Job}, {Age}, {Department}");
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Age = 25;
            employee.FirstName = "Kiran";
            employee.LastName = "Kumar";

            employee.EmployeeId = 120256;
            employee.Job = "Manager";
            employee.Department = "Accounts";

            employee.PrintDetails();


            Console.ReadLine();
        }
    }
}
