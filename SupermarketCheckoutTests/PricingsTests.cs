using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupermarketCheckout;
using SupermarketInterfaces;
using System;
namespace SupermarketCheckoutTests
{
    [TestClass]
    public class PricingsTests
    {
        [TestMethod]
        public void AddProduct_Successful()
        {
            IPricings pricings = new Pricings();

            pricings.AddProduct("HGUG484JV", 1.00f);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void AddDeal_Successful()
        {
            IPricings pricings = new Pricings();

            pricings.AddDeal("HGUG484JV", 3, 2.00f);
            pricings.AddDeal("HGUG484JV", 7, 4.20f);

            Assert.IsTrue(true);
        }
    }
}
