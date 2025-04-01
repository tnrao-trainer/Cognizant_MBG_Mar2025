using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }



        }
    }
}