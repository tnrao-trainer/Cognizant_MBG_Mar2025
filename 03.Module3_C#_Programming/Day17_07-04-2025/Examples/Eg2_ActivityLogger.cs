using System;
using System.IO;

class ActivityLogger
{
    static void Main()
    {
        string logPath = Path.Combine("Logs", "activity_log.txt");
        Directory.CreateDirectory("Logs");

        using (StreamWriter sw = new StreamWriter(logPath, true))
        {
            sw.WriteLine($"App opened at {DateTime.Now}");
        }

        Console.WriteLine("Activity logged.");
    }
}