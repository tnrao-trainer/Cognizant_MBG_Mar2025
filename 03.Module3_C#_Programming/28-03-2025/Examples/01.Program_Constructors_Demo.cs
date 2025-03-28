 
namespace ConsoleApp21
{

    internal class Employee
    {
        // Properties
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employee()
        {
            EmpId = 0;
            Name = string.Empty;
            Salary = 0;
        }

        public Employee(int id)
        {
            EmpId = id;
            Name = string.Empty;
            Salary = 0;
        } 
       
        public Employee(int id, string ename)
        {
            EmpId = id;
            Name = ename;
            Salary = 0;
        }

        public Employee(int id, string ename, double salary)
        {
            EmpId = id;
            Name = ename;
            Salary = salary;
        }

        public void ShowDetails()
        {
           // Console.WriteLine("Emp Id : {0}, Name : {1}, Salary : {2}", EmpId, Name, Salary);
            Console.WriteLine($"Emp Id : {EmpId}, Name : {Name}, Salary : {Salary}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empObj1 = new Employee();
            Employee empObj2 = new Employee(1256);
            Employee empObj3 = new Employee(15896, "Scott");
            Employee empObj4 = new Employee(15896, "Scott", 50000);


            empObj1.ShowDetails();
            empObj2.ShowDetails();
            empObj3.ShowDetails();
            empObj4.ShowDetails();

            Console.ReadLine();
           
        }
    }
}
