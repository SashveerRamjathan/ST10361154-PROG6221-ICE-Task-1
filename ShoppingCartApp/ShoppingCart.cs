using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppOop.ShoppingCartApp
{
    internal class ShoppingCart
    {

        private Product[] products;
        private int itemCount;

        public Product[] Products { get { return products; } }

        public int ItemCount { get { return itemCount; } }

        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];

            itemCount = 0;
        }

        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
            }
            else
            {
                Console.WriteLine("Shopping cart is full. Cannot add more items.");
            }
        }

        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i] == product)
                {
                    // Shift elements to remove the product
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }

                    products[itemCount - 1] = null; // Set the last element to null
                    itemCount--;

                    Console.WriteLine(product.Name + " removed from the shopping cart.");
                    return;
                }
            }
        }

        public void DisplayCartTotal()
        {
            double total = 0;

            foreach (Product product in products)
            {
                if (product != null)
                {
                    total += product.Price;
                }
            }

            double vat = total * 0.15;

            double grandTotal = total + vat;

            Console.WriteLine("\nVAT: " + Math.Round(vat, 2) + "\nGrand Total: " + Math.Round(grandTotal, 2));
        }

        public void DisplayCart()
        {
            Console.WriteLine("There are " + itemCount + " item(s) in your cart: ");

            foreach (Product product in products)
            {
                if (product != null)
                {
                    Console.WriteLine(product.GetInfo());
                }
            }
        }

        public void DisplayTempCart()
        {
            int i = 1;

            foreach (Product product in products)
            {
                if (product != null)
                {
                    Console.Write(i + ". " + product.GetInfo() + "\n\n");
                    i++;
                }
            }
        }

        public Product GetProduct(int id)
        {
            Product product = products[id];

            return product;
        }
    }
}
