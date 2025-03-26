using System;

class EvenNumbers
{
    static void Main()
    {
        Console.WriteLine("Even Numbers from 1 to 50:");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
