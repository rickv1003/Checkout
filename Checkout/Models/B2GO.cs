using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.Interfaces;

namespace Checkout.Models
{
    public class B2GO<T> : Discount, IDiscount where T : Produce
    {
        public B2GO(List<Pricing> pricing)
        {
            _pricing = pricing;

            base.CheckForPricing(typeof(T));
        }

        public double CalculateDiscount(List<Produce> produce)
        {
            int c = produce.Count(x => x.GetType() == typeof(T));

            double discountAmount = c / 3 * _pricing.First(x => x.Item == typeof(T)).Price;

            return discountAmount;
        }
    }
}
