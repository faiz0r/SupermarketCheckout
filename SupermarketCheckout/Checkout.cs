using SupermarketInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout
{
    public class Checkout : ICheckout
    {

        private IPricings _pricing = new Pricings();
        private List<Product> _basket = new List<Product>();
        public void Configure(IPricings pricings)
        {
            _pricing = pricings;
        }

        public void Empty()
        {
            this._basket.Clear();
        }

        public void Remove(string sku)
        {
            this._basket.RemoveAll(x => x.Sku == sku);
        }

        public float Savings()
        {
            throw new NotImplementedException();

        }

        public void Scan(string sku)
        {
            _basket.Add(sku);
        }

        public float Subtotal()
        {
            throw new NotImplementedException();
        }

/*        public int DiscountPrice(string sku, ref int numberOfItemsToCalculatePriceFor)
        {
            var discount = this.deal.Where(x => x.Sku == sku).FirstOrDefault();
            if (discount == null) return 0; // no discounted price for this product

            var discountedPrice = (numberOfItemsToCalculatePriceFor / discount.NumberOfItems) * discount.Price;

            // number of items to still calculate price for
            numberOfItemsToCalculatePriceFor = numberOfItemsToCalculatePriceFor % discount.NumberOfItems;

            return discountedPrice;
        }*/

        public float Total()
        {
            float total = 0;
            foreach(var basket in _basket)
            {
                total += basket.Price;
            }

            return total;
        }
    }
}
