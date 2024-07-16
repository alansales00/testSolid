using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Discounts
{
    public interface IDiscount
    {
        public void ApplyDiscount(double discountPercentage);
    }
}
