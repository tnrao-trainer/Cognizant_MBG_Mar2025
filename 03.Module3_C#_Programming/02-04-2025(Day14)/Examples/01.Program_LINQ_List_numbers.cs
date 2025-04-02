using System;
 

namespace ConsoleApp9
{
    class Program
    {        
        static void Main()
        {
            List<int> lstNumbers = new List<int>() { 46, 55, 10, 20, 35, 37, 42  };


            var q1 = from item in lstNumbers
                     where item % 2 == 0
                     orderby item descending
                     select item;

            foreach (var n in q1)
            {
                Console.Write($"{n}  ");
            }



            Console.ReadLine();
        }
    }
}
