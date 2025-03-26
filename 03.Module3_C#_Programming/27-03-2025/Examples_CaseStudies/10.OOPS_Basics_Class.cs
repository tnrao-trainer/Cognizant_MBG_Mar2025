using System;

class Student
{
    public string Name;
    public int Age;
    public string Course;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Course: {Course}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "Alice";
        student1.Age = 21;
        student1.Course = "Computer Science";

        student1.DisplayInfo();
    }
}