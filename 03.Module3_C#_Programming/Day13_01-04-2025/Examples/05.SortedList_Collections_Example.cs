using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    
    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}, Salary : {Salary}";
    }
}

public class Program
{
    public static void Main()
    {
        SortedList<int, Employee> employees = new SortedList<int, Employee>
        {
            { 3, new Employee { Id = 3, Name = "Charlie", Salary = 55000 } },
            { 1, new Employee { Id = 1, Name = "Alice", Salary = 50000 } },
            { 2, new Employee { Id = 2, Name = "Bob", Salary = 60000 } }
        };

        // Access by key
        Employee employeeByKey = employees[2];
      //  Console.WriteLine($"Access by key: Name: {employeeByKey.Name}, Salary: {employeeByKey.Salary}");
          Console.WriteLine($"{employeeByKey}");

        // Access by index
        Employee employeeByIndex = employees.Values[0];
    //    Console.WriteLine($"Access by index: Name: {employeeByIndex.Name}, Salary: {employeeByIndex.Salary}");
         Console.WriteLine($"{employeeByIndex}");

        // Iterate over the SortedList
        foreach (var kvp in employees)
        {
            // Console.WriteLine($"Key: {kvp.Key}, Name: {kvp.Value.Name}, Salary: {kvp.Value.Salary}");
            Console.WriteLine($"Key: {kvp.Key}, Value : {kvp.Value}");
        }

        // Remove an element
        employees.Remove(1);
        Console.WriteLine("After removing key 1:");
        foreach (var kvp in employees)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value : {kvp.Value}");
        }
    }
}