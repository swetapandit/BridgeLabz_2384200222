/*using System;

class Product
{
    public static double Discount = 0;  // Static discount shared by all products

    public readonly int ProductID;  // Unique and unchangeable ID for each product

    public string ProductName;
    public double Price;
    public int Quantity;

    // Static method to update the discount
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine($"\nDiscount updated to {Discount}%\n");
    }

    // Constructor using 'this' keyword
    public Product(int id, string name, double price, int quantity)
    {
        this.ProductID = id;
        this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Method to display product details
    public void DisplayDetails()
    {
        Console.WriteLine($"Product ID: {ProductID}, Name: {ProductName}");
        Console.WriteLine($"Price: {Price}, Quantity: {Quantity}");
        Console.WriteLine($"Price after {Discount}% discount: {Price - (Price * Discount / 100)}\n");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of products: ");
        int numProducts = int.Parse(Console.ReadLine());

        // Allow user to update discount
        Console.Write("\nEnter discount percentage: ");
        double discount = double.Parse(Console.ReadLine());
        Product.UpdateDiscount(discount);

        // Creating a fixed-size array to store products
        Product[] cart = new Product[numProducts];

        // Taking user input to create products
        for (int i = 0; i < numProducts; i++)
        {
            Console.WriteLine($"\nEnter details for Product {i + 1}:");
            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            cart[i] = new Product(id, name, price, quantity);
        }

        // Display all products after validation
        Console.WriteLine("\nShopping Cart Details:");
        for (int i = 0; i < numProducts; i++)
        {
            if (cart[i] is Product)
            {
                cart[i].DisplayDetails();
            }
        }
        Console.ReadLine();
    }
}
*/