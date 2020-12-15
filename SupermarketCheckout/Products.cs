using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout
{
    class Products
    {
        private List<Product> products = new List<Product>();

        public Products UpdateProduct(string sku, int price)
        {
            this.products.RemoveAll(x => x.Sku == sku);
            this.products.Add(new Product(sku, price));
            return this;
        }

        public Products RemoveProduct(string sku)
        {
            this.products.RemoveAll(x => x.Sku == sku);
            return this;
        }

        public int GetPrice(string sku)
        {
            var product = this.products.Where(x => x.Sku == sku).FirstOrDefault();
            return product.Price;
        }
    }
}
