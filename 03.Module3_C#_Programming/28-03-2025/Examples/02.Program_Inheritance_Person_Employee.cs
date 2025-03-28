 
namespace ConsoleApp21
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }
        public string Department { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.Age = 25;
            employee.FirstName = "Kiran";
            employee.LastName = "Kumar";

            employee.EmployeeId = 120256;
            employee.Job = "Manager";
            employee.Department = "Accounts";


            Console.WriteLine($"{employee.FirstName}, {employee.LastName}, {employee.EmployeeId}, {employee.Job}, {employee.Age}, {employee.Department}");

            Console.ReadLine();           
        }
    }
}
