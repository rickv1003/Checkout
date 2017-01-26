using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.Models;
using Checkout.Interfaces;

namespace Checkout.Services
{
    public class CheckoutService : ICheckout
    {
        private List<Pricing> _pricing;
        private List<IDiscount> _discounts;

        public CheckoutService(List<Pricing> pricing, List<IDiscount> discounts)
        {
            _pricing = pricing;
            _discounts = discounts;
        }

        public Models.Receipt Total(List<Produce> produce)
        {
            double subtotal = 0;
            double discount = 0;

            foreach(Produce p in produce)
            {
                if (_pricing.Count(x => x.Item == p.GetType()) == 0)
                {
                    throw new Exception("No pricing for selected discount item");
                }
                else if (_pricing.Count(x => x.Item == p.GetType()) > 1)
                {
                    throw new Exception("Multiple pricing for selected discount item");
                }

                subtotal += _pricing.Single(x => x.Item == p.GetType()).Price;
            }

            if(_discounts != null) { 
                foreach (IDiscount d in _discounts)
                {
                    discount += d.CalculateDiscount(produce);
                }
            }

            return new Receipt(Math.Round(subtotal,2), Math.Round(discount,2));
        }
    }
}
