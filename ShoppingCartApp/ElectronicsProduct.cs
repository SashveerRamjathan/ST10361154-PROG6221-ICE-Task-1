using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class ElectronicsProduct : Product
    {
        private string brand;
        private string model;

        public string Brand
        {
            get { return brand; }
        }
        public string Model
        {
            get { return model; }
        }

        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model) : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        public override string GetInfo()
        {
            string info;
            string temp = base.GetInfo();

            info = "\n" + temp + "\n Product Brand: " + brand
                + "\n Product Model: " + model;

            //Console.WriteLine(base.GetInfo + info);
            return info;
        }
    }
}
