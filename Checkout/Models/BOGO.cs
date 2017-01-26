using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.Interfaces;

namespace Checkout.Models
{
    public class BOGO<T> : Discount, IDiscount where T : Produce
    {
        public BOGO(List<Pricing> pricing)
        {
            _pricing = pricing;

            base.CheckForPricing(typeof(T));
        }

        public double CalculateDiscount(List<Produce> produce)
        {
            int c = produce.Count(x => x.GetType() == typeof(T));

            if (c == 0)
                return 0;

            double discountAmount = c / 2 * _pricing.First(x => x.Item == typeof(T)).Price;

            return discountAmount;
        }
    }
}
