using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class Product
    {
        private string name;
        private double price;
        private ProductCategory category;

        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public ProductCategory Category
        {
            set { category = value; }
            get { return category; }
        }


        public virtual string GetInfo()
        {
            string info;

            info = "Product name: " + name + "\nPrice: " + price + "\nProduct Category: " + category;

            //Console.WriteLine(info);

            return info;
        }
    }
}
