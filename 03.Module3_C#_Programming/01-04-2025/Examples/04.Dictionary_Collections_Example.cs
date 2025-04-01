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
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>
        {
            { 1, new Employee { Id = 1, Name = "Alice", Salary = 50000 } },
            { 2, new Employee { Id = 2, Name = "Bob", Salary = 60000 } },
            { 3, new Employee { Id = 3, Name = "Charlie", Salary = 55000 } }
        };

        // Access an element by key
        Employee obj = employees[2];
        // Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        Console.WriteLine($"{obj}");

        // Iterate over the Dictionary
        foreach (var kvp in employees)
        {
           // Console.WriteLine($"Key: {kvp.Key}, Name: {kvp.Value.Name}, Salary: {kvp.Value.Salary}");
            Console.WriteLine($"Key: {kvp.Key},  Value :  {kvp.Value}");
        }

        // Add a new employee
        employees.Add(4, new Employee { Id = 4, Name = "David", Salary = 70000 });

        // Update an existing employee's salary
        if (employees.ContainsKey(2) == true)
        {
            employees[2].Salary = 65000;
        }

        // Remove an employee 
        employees.Remove(3);

        // Display the updated Dictionary
        Console.WriteLine("Updated Dictionary:");
        foreach (var kvp in employees)
        {
            Console.WriteLine($"Key: {kvp.Key},  Value :  {kvp.Value}");
        }
    }
}