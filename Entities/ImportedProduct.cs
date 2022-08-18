using System;
using System.Globalization;

namespace Market.Entities
{
    internal class ImportedProduct:Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name,double price, double customsFee)
        :base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return Name + " U$" + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + "  Customs fee: U$" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
