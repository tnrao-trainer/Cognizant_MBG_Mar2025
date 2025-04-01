using System;

public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}


public class Program
{
    public static void Main()
    {
        // Using enum in a switch statement
        DaysOfWeek today = DaysOfWeek.Tuesday;

        

        switch (today)
        {
            case DaysOfWeek.Sunday:
                Console.WriteLine("It's Sunday, time to relax!");
                break;
            case DaysOfWeek.Monday:
                Console.WriteLine("It's Monday, back to work!");
                break;
            case DaysOfWeek.Wednesday:
                Console.WriteLine("It's Wednesday, halfway through the week!");
                break;
            default:
                Console.WriteLine("It's another day of the week.");
                break;
        }

        // Convert enum to string
        string todayString = today.ToString();
        Console.WriteLine($"Today is {todayString}");

        // Convert string to enum
        string dayString = "Monday";
        DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayString);
        Console.WriteLine($"Parsed day: {day}");

    }
}