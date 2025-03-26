using System;

class Program
{
    static double CalculateNetSalary(double grossSalary, double taxRate)
    {
        double tax = grossSalary * taxRate;
        return grossSalary - tax;
    }

    static void Main()
    {
        double grossSalary = 50000;
        double taxRate = 0.12; // 12% tax
        double netSalary = CalculateNetSalary(grossSalary, taxRate);

        Console.WriteLine("Employee Salary Calculator");
        Console.WriteLine($"Gross Salary: {grossSalary}");
        Console.WriteLine($"Tax Rate: {taxRate * 100}%");
        Console.WriteLine($"Net Salary: {netSalary}");
    }
}
