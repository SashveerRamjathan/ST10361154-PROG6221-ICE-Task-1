using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class ClothingProduct : Product
    {
        private string size;
        private string colour;

        public string Size
        {
            get { return size; }
        }

        public string Colour
        {
            get { return colour; }
        }
        public ClothingProduct(string name, double price, ProductCategory category, string size, string colour) : base(name, price, category)
        {
            this.size = size;
            this.colour = colour;
        }

        public override string GetInfo()
        {
            string info;
            string temp = base.GetInfo();

            info = "\n" + temp + "\n Product Size: " + size
                + "\n Product Colour: " + colour;

            //Console.WriteLine(base.GetInfo + info);

            return info;
        }
    }
}
