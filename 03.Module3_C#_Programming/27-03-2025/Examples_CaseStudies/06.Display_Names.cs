using System;

class Program
{
    static void Main()
    {
        string[] names = new string[5];
        Console.WriteLine("Enter 5 names:");

        for (int i = 0; i < names.Length; i++)
        {
            names[i] = Console.ReadLine();
        }

        Console.WriteLine("\nNames entered:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
