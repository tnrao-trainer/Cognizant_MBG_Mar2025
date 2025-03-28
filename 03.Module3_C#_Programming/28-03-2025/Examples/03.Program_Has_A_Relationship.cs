﻿ 
namespace ConsoleApp21
{  

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }

        public Address(string street, string city, string pinCode)
        {
            Street = street;
            City = city;
            PinCode = pinCode;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Address: {Street}, {City}, {PinCode}");
        }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Address EmployeeAddress { get; set; } // Has-A Relationship

        public Employee(int employeeId, string name, double salary, Address address)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
            EmployeeAddress = address;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Salary: INR.{Salary}");
            EmployeeAddress.DisplayAddress(); // Display Address details
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an Address object
            Address empAddress = new Address("15th Line, Ameerept", "Hyderabad", "500018");

            // Creating an Employee object and passing Address
            Employee emp = new Employee(10144, "Narasimha", 75000, empAddress);

        //    emp.EmployeeAddress.PinCode = "658664";


            // Display Employee Details
            emp.DisplayEmployee();
        }
    }

}
