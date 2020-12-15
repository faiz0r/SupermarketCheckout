using SupermarketInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout
{
    public class Pricings : IPricings
    {
        private List<Product> product = new List<Product>();
        private List<Deal> deal = new List<Deal>();

        public void AddDeal(string sku, int count, float price)
        {
            this.deal.Add(new Deal(sku, count, price));
        }

        public void AddProduct(string sku, float price)
        {
            this.product.Add(new Product(sku, price));
        }
    }
}
