 public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age;

        try
        {
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw new InvalidAgeException("You must be 18 or older to vote.");
            }
            Console.WriteLine("You are eligible to vote!");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
}