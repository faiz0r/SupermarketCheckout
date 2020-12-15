using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout
{
    public class Product
    {
        public readonly string Sku;
        public readonly float Price;
        public Product(string sku, float price)
        {
            this.Price = price;
            this.Sku = sku;
        }
    }
}
