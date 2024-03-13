using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class HomeProduct : Product
    {
        private string functionality;
        private string dimensions;
        private string material;

        public string Functionality
        {
            get { return functionality; }
        }

        public string Dimensions
        {
            get { return dimensions; }
        }

        public string Material
        {
            get { return material; }
        }

        public HomeProduct(string name, double price, ProductCategory category, string functionality, string dimensions, string material) : base(name, price, category)
        {
            this.functionality = functionality;
            this.dimensions = dimensions;
            this.material = material;
        }

        public override string GetInfo()
        {
            string info;
            string temp = base.GetInfo();

            info = "\n" + temp + "\nProduct Functionality: " + functionality
               + "\nProduct Dimensions: " + dimensions
               + "\nProduuct Material: " + material;

            // Console.WriteLine(base.GetInfo + info);

            return info;
        }
    }
}
