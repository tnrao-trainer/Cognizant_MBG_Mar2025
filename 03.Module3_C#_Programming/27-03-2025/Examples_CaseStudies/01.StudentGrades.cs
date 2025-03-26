
using System;

class StudentGrade
{
    static void Main()
    {
        int math = 85, science = 88, english = 92;
        
        double average = (math + science + english) / 3.0;
        
        char grade;

        if (average >= 90) 
            grade = 'A';
        else if (average >= 80) 
            grade = 'B';
        else if (average >= 70) 
            grade = 'C';
        else grade = 'D';

        Console.WriteLine($"Average Marks: {Math.Round(average, 2)}");
        Console.WriteLine($"Grade: {grade}");
    }
}