using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication30
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}