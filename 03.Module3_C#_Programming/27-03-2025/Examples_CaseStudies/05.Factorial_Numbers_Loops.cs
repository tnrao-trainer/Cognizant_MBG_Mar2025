using System;

class FactorialProgram
{
    static int CalculateFactorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a number to calculate factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int factorial = CalculateFactorial(num);
        Console.WriteLine($"Factorial of {num} is {factorial}");
    }
}
