using System;

class ProductBilling
{
    static void Main()
    {
        int productCount;
        Console.Write("Enter number of products: ");
        productCount = Convert.ToInt32(Console.ReadLine());

        string[] products = new string[productCount];
        double[] prices = new double[productCount];
        double total = 0;

        for (int i = 0; i < productCount; i++)
        {
            Console.Write($"Enter name of product {i + 1}: ");
            products[i] = Console.ReadLine();
            Console.Write($"Enter price of {products[i]}: ");
            prices[i] = Convert.ToDouble(Console.ReadLine());
            total += prices[i];
        }

        Console.WriteLine("\n----- Bill -----");
        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine($"{products[i]}: ${prices[i]}");
        }
        Console.WriteLine($"Total Bill: ${total}");
    }
}
