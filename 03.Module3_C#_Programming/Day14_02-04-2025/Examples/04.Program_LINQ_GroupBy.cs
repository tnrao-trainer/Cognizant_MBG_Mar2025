 using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp21
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }

    class Program
    {
        static void Main()
        {

            List<Product> products = new List<Product>
{
    new Product { ProductId = 1, Name = "Apple", Price = 0.5m, Qty = 10 },
    new Product { ProductId = 2, Name = "Banana", Price = 0.3m, Qty = 5 },
    new Product { ProductId = 3, Name = "Orange", Price = 0.6m, Qty = 10 },
    new Product { ProductId = 4, Name = "Mango", Price = 1.2m, Qty = 5 },
    new Product { ProductId = 5, Name = "Kiwi", Price = 1.3m, Qty = 5 }
};

            var result = (from p in products
                          group p by p.Qty into g
                          from item in
                              new[] { $"{g.Key}" }.Concat(g.Select(x => x.Name))
                          select item
             ).ToList();

            var result2 = products.GroupBy(p => p.Qty)
                        .SelectMany(g =>
                                new[] { $"{g.Key}" }.Concat(g.Select(p => p.Name))
                        ).ToList();




            foreach (string item in result2)
            {
                Console.WriteLine(item);

            }



            Console.ReadLine();

        }
    }
}
