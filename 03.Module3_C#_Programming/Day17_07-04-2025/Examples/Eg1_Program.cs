
using System.IO;

namespace ConsoleApp21
{    class Program
    {
        static void Main(string[] args)
        {
            string strData = $"\nMessage prepared at {DateTime.Now}";
        //    File.WriteAllText("TestFile.txt", strData);
            File.AppendAllText("TestFile.txt", strData);
           

            Console.WriteLine("Message is written on File");

            Console.ReadLine();
        }
    }
}