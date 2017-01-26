using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Models
{
    public class Pricing
    {
        public Type Item { get; set; }
        public double Price { get; set; }

        public Pricing(Type item, double price)
        {
            Item = item;
            Price = price;
        }
    }
}
