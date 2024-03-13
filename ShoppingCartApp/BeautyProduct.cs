using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class BeautyProduct : Product
    {
        private string brand;
        private string skinType;
        private bool isOrganic;
        private int spfLevel;

        public string Brand
        {
            get { return brand; }
        }

        public string SkinType
        {
            get { return skinType; }
        }

        public bool IsOrganic
        {
            get { return isOrganic; }
        }

        public int SpfLevel
        {
            get { return spfLevel; }
        }

        public BeautyProduct(string name, double price, ProductCategory category, string brand, string skinType, bool organic, int spfLevel) : base(name, price, category)
        {
            this.brand = brand;
            this.skinType = skinType;
            isOrganic = organic;
            this.spfLevel = spfLevel;
        }

        public override string GetInfo()
        {
            string info;
            string temp = base.GetInfo();

            info = "\n" + temp + "\nProduct Brand: " + brand
               + "\nProduct Skin Type: " + skinType
               + "\nIs Product Organic: " + isOrganic
               + "\nProduct SPF Level: " + spfLevel;

            // Console.WriteLine(base.GetInfo + info);

            return info;
        }
    }
}
