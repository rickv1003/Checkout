using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.Models;
using Checkout.Interfaces;

namespace Checkout.Tests
{
    public static class CheckoutSetup
    {
        public static List<Produce> GetProduce()
        {
            List<Produce> p = new List<Produce>(new Produce[] { new Apple(Apple.AppleColor.Red),
                                                 new Orange(Orange.OrangeVariety.Mandarin),
                                                 new Apple(Apple.AppleColor.Green),
                                                 new Apple(Apple.AppleColor.Red)});

            return p;
        }

        public static List<Produce> GetProduce2()
        {
            List<Produce> p = new List<Produce>(new Produce[] { new Apple(Apple.AppleColor.Red),
                                                 new Orange(Orange.OrangeVariety.Mandarin),
                                                 new Apple(Apple.AppleColor.Green),
                                                 new Apple(Apple.AppleColor.Red),
                                                 new Orange(Orange.OrangeVariety.Mandarin),
                                                 new Orange(Orange.OrangeVariety.Mandarin),
                                                 new Orange(Orange.OrangeVariety.Clementine),
                                                 new Orange(Orange.OrangeVariety.Mandarin)});

            return p;
        }

        public static List<IDiscount> GetDiscounts(List<Pricing> pricing)
        {
            List<IDiscount> r = new List<IDiscount>(new IDiscount[] { new BOGO<Apple>(pricing), new B2GO<Orange>(pricing) });

            return r;
        }

        public static List<Pricing> GetPricing()
        {
            List<Pricing> r = new List<Pricing>(new Pricing[]{ new Pricing(typeof(Apple), .45), new Pricing(typeof(Orange), .65) });

            return r;
        }
    }
}
