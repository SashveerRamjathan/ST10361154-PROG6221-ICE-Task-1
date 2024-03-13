using ShoppingCartAppOop.ShoppingCartApp;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating Clothing Products
        Product clothingProduct1 = new ClothingProduct("T-Shirt", 299.85, ProductCategory.Clothing, "M", "Blue");
        Product clothingProduct2 = new ClothingProduct("Jeans", 599.85, ProductCategory.Clothing, "L", "Black");
        Product clothingProduct3 = new ClothingProduct("Dress", 749.85, ProductCategory.Clothing, "S", "Red");
        Product clothingProduct4 = new ClothingProduct("Jacket", 1199.85, ProductCategory.Clothing, "XL", "Black");

        // Creating Electronics Products
        Product electronicsProduct1 = new ElectronicsProduct("Smartphone", 8999.85, ProductCategory.Electronics, "Samsung", "Galaxy S21");
        Product electronicsProduct2 = new ElectronicsProduct("Laptop", 14999.85, ProductCategory.Electronics, "Dell", "XPS 13");
        Product electronicsProduct3 = new ElectronicsProduct("Headphones", 1349.85, ProductCategory.Electronics, "Sony", "WH-1000XM4");
        Product electronicsProduct4 = new ElectronicsProduct("Smartwatch", 2249.85, ProductCategory.Electronics, "Apple", "Watch Series 7");

        // Creating Home Products
        Product homeProduct1 = new HomeProduct("Coffee Table", 1949.85, ProductCategory.Home, "Living Room", "91.44x60.96x45.72 cm", "Wood");
        Product homeProduct2 = new HomeProduct("Desk Lamp", 524.85, ProductCategory.Home, "Study Room", "38.1 cm height", "Metal");
        Product homeProduct3 = new HomeProduct("Dining Table", 3749.85, ProductCategory.Home, "Dining Room", "182.88x91.44 cm", "Glass");
        Product homeProduct4 = new HomeProduct("Bedside Lamp", 299.85, ProductCategory.Home, "Bedroom", "50.8 cm height", "Plastic");


        // Creating Beauty Products
        Product beautyProduct1 = new BeautyProduct("Moisturizer", 374.85, ProductCategory.Beauty, "Cetaphil", "Normal", true, 30);
        Product beautyProduct2 = new BeautyProduct("Sunscreen", 239.85, ProductCategory.Beauty, "Neutrogena", "Sensitive", false, 50);
        Product beautyProduct3 = new BeautyProduct("Shampoo", 194.85, ProductCategory.Beauty, "Pantene", "All Hair Types", false, 0);
        Product beautyProduct4 = new BeautyProduct("Lipstick", 134.85, ProductCategory.Beauty, "Maybelline", "Matte", true, 15);

        // Creating Groceries Products
        Product groceriesProduct1 = new GroceriesProduct("Cereal", 89.85, ProductCategory.Groceries, "Kellogg's", "2024-12-31", "Whole Grain", "None");
        Product groceriesProduct2 = new GroceriesProduct("Milk", 27.35, ProductCategory.Groceries, "Organic Farms", "2024-3-31", "Dairy", "Lactose");
        Product groceriesProduct3 = new GroceriesProduct("Fresh Fruits Assorted", 119.85, ProductCategory.Groceries, "Local Farm", "2024-4-30", "Fruit", "None");
        Product groceriesProduct4 = new GroceriesProduct("Bread", 17.35, ProductCategory.Groceries, "Bakery X", "2024-3-15", "Whole Wheat", "Gluten");


        //create a temp shopping cart object to display all products to customer
        ShoppingCart displayCart = new ShoppingCart(20);


        // Adding all products to the temp cart to display
        displayCart.AddProduct(beautyProduct1);
        displayCart.AddProduct(beautyProduct2);
        displayCart.AddProduct(beautyProduct3);
        displayCart.AddProduct(beautyProduct4);

        displayCart.AddProduct(clothingProduct1);
        displayCart.AddProduct(clothingProduct2);
        displayCart.AddProduct(clothingProduct3);
        displayCart.AddProduct(clothingProduct4);

        displayCart.AddProduct(electronicsProduct1);
        displayCart.AddProduct(electronicsProduct2);
        displayCart.AddProduct(electronicsProduct3);
        displayCart.AddProduct(electronicsProduct4);

        displayCart.AddProduct(homeProduct1);
        displayCart.AddProduct(homeProduct2);
        displayCart.AddProduct(homeProduct3);
        displayCart.AddProduct(homeProduct4);

        displayCart.AddProduct(groceriesProduct1);
        displayCart.AddProduct(groceriesProduct2);
        displayCart.AddProduct(groceriesProduct3);
        displayCart.AddProduct(groceriesProduct4);

        Console.WriteLine("Hello, Welcome to my small shopping app. \nWe have a few things on sale today.");
        Console.WriteLine("Heres all the items we have in stock today: \n");

       displayCart.DisplayTempCart();

        //create another temp shopping cart to hold products intermitently before adding to main cart
        ArrayList tempCart = new ArrayList();

        Boolean toContinue = false;
        int userItemChoice = -1;

        do
        {
            userItemChoice = getUserOrderChoice();

            tempCart.Add(displayCart.GetProduct(userItemChoice));

            toContinue = promptToContinue();

        } while (toContinue == true);

        ShoppingCart mainCart = new ShoppingCart(tempCart.Count);

        foreach (Product item in tempCart)
        {
            mainCart.AddProduct(item);
        }

        mainCart.DisplayCart();

        Console.WriteLine("---------------------------------------------------------------------------------------------------" + 
            "\nBill" + 
            "\n---------------------------------------------------------------------------------------------------");

        mainCart.DisplayCartTotal();

    }

    public static int getUserOrderChoice()
    {
        Console.WriteLine("Please enter number of the item you would like to order: ");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        int actualItem = (userChoice - 1);

        return actualItem;
    }

    public static Boolean promptToContinue()
    {
        Boolean toContinue = false;

        Console.WriteLine("Do you want to continue with your order?" + "\nEnter (1) to continue or (0) to generate a total");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        if (userChoice == 1)
        {
            toContinue = true;
        }

        return toContinue;

    }
}