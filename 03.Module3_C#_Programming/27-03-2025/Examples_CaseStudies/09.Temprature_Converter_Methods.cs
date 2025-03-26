using System;

class TemperatureConversion
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Fahrenheit: {CelsiusToFahrenheit(celsius)}");

        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Celsius: {FahrenheitToCelsius(fahrenheit)}");
    }
}
