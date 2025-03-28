using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    //  Method Overloading

    class Hello
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to C# Methods");
        }
        

        public void Greeting(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Hi , How are you?");
            }
        }
        public void Greeting(string uname)
        {
            Console.WriteLine("Welcome to " + uname);
        }
        public void Greeting(string uname, string timeOfDay)
        {
            Console.WriteLine("Hi {0}, Good {1}...!", uname, timeOfDay);
        }
        public void Greeting(string uname, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Welcome to " + uname);
            }
        }
        public void Greeting(int number, string uname)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Welcome to " + uname);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Hello obj = new Hello();
            obj.Greeting();
            System.Console.WriteLine("--------------------------------");
            obj.Greeting(4);
            System.Console.WriteLine("--------------------------------");
            obj.Greeting("Scott");
            System.Console.WriteLine("--------------------------------");
            obj.Greeting("Scott", "Morning");
            System.Console.WriteLine("--------------------------------");
            obj.Greeting("Scott", 3);
            System.Console.WriteLine("--------------------------------");
            obj.Greeting(3, "Scott");
            System.Console.WriteLine("--------------------------------");

            Console.ReadLine();
        }
    }
}
