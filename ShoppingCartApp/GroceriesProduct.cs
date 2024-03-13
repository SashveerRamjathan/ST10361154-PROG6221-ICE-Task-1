using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class GroceriesProduct : Product
    {
        private string brand;
        private string expirationDate;
        private string dietryInfo;
        private string allergens;

        public string Brand
        {
            get { return brand; }
        }

        public string ExpirationDate
        {
            get { return expirationDate; }
        }

        public string DietryInfo
        {
            get { return dietryInfo; }
        }

        public string Allergens
        {
            get { return allergens; }
        }

        public GroceriesProduct(string name, double price, ProductCategory category, string brand, string expirationDate, string dietryInfo, string allergens) : base(name, price, category)
        {
            this.brand = brand;
            this.expirationDate = expirationDate;
            this.dietryInfo = dietryInfo;
            this.allergens = allergens;
        }

        public override string GetInfo()
        {
            string info;
            string temp = base.GetInfo();

            info = "\n" + temp + "\nProduct Brand: " + brand
               + "\nProduct Expiration Date: " + expirationDate
               + "\nProduct Dietry Info: " + dietryInfo
               + "\nProduct Allergens: " + allergens;

            // Console.WriteLine(base.GetInfo + info);

            return info;
        }
    }
}
