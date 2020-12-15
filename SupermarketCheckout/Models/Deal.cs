using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout
{
    class Deal
    {
        public readonly string Sku;
        public readonly int NumberOfItems;
        public readonly float Price;
        public Deal(string sku, int count, float price)
        {
            this.Sku = sku;
            this.NumberOfItems = count;
            this.Price = price;
        }

    }
}
