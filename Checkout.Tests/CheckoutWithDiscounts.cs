using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Checkout.Models;
using Checkout.Interfaces;
using Checkout.Services;

namespace Checkout.Tests
{
    public partial class Checkout
    { 
        [TestMethod]
        public void CheckoutWithDiscounts()
        {
            List<Pricing> pricing = CheckoutSetup.GetPricing();
            List<IDiscount> discounts = CheckoutSetup.GetDiscounts(pricing);

            ICheckout cService = new CheckoutService(pricing, discounts);
            Receipt rct = cService.Total(CheckoutSetup.GetProduce());

            Assert.AreEqual(rct.Total, 1.55);
        }

        [TestMethod]
        public void CheckoutWithDiscounts2()
        {
            List<Pricing> pricing = CheckoutSetup.GetPricing();
            List<IDiscount> discounts = CheckoutSetup.GetDiscounts(pricing);

            ICheckout cService = new CheckoutService(pricing, discounts);
            Receipt rct = cService.Total(CheckoutSetup.GetProduce2());

            Assert.AreEqual(rct.Total, 3.5);
        }
    }
}
