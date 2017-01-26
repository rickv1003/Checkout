using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Checkout.Models;
using Checkout.Interfaces;
using Checkout.Services;

namespace Checkout.Tests
{
    [TestClass]
    public partial class Checkout
    {
        [TestMethod]
        public void CheckoutNoDiscounts()
        {
            List<Pricing> pricing = CheckoutSetup.GetPricing();

            ICheckout cService = new CheckoutService(pricing, null);
            Receipt rct = cService.Total(CheckoutSetup.GetProduce());

            Assert.AreEqual(rct.Total,2);
        }

        [TestMethod]
        public void CheckoutNoDiscounts2()
        {
            List<Pricing> pricing = CheckoutSetup.GetPricing();

            ICheckout cService = new CheckoutService(pricing, null);
            Receipt rct = cService.Total(CheckoutSetup.GetProduce2());

            Assert.AreEqual(rct.Total, 4.6);
        }
    }
}