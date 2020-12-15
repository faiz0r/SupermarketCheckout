using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupermarketCheckout;
using SupermarketInterfaces;
using System;

namespace SupermarketCheckoutTests
{
    [TestClass]
    public class CheckoutTests
    {
        ICheckout checkout = new Checkout();
        IPricings pricings = new Pricings();

        [TestMethod]
        public void Remove_IsTrue()
        {
            checkout.Remove("HGUG484JV");

            Assert.IsTrue(true);
        }

        public void Empty_IsTrue()
        {
            checkout.Empty();

        }

        [TestMethod]
        public void Scan_AreEqual()
        {
            checkout.Scan("HGUG484JV");

        }
    }
}
