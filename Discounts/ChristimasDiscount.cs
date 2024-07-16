using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Discounts;

namespace ConsoleApp1.Discounts
{
    class ChristimasDiscount : IDiscount
    {
        public void ApplyDiscount(double discountPercentage)
        {
            Console.WriteLine($"Applying {discountPercentage}% discount to all books");
        }
    }
}
