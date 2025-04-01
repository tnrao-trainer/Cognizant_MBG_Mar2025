using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method
    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating an instance of the structure
        Point p1 = new Point(10, 20);
        p1.Display();

        // Copying the structure
        Point p2 = p1;
        p2.X = 30;
        p2.Display();

        // Display original structure to show it is not affected by the copy
        p1.Display();
    }
}