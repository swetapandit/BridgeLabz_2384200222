/*using System;

class Product
{
    // Instance Variables (unique for each product)
    public string productName;
    public double price;

    // Class Variable (shared among all products)
    public static int totalProducts = 0;

    // Constructor to initialize product details
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++; // Increments total count for each new product
    }

    // Instance Method to display product details
    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {this.productName}, Price: {this.price:C}");
    }

    // Static Method to display total products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products in Inventory: {totalProducts}");
    }
}

class Program
{
    static void Main()
    {
        // Creating Product Objects
        Product p1 = new Product("Laptop", 75000);
        Product p2 = new Product("Smartphone", 45000);
        Product p3 = new Product("Headphones", 2500);

        // Displaying Individual Product Details
        p1.DisplayProduct();
        p2.DisplayProduct();
        p3.DisplayProduct();

        Console.WriteLine();

        // Displaying Total Products (Using Static Method)
        Product.DisplayTotalProducts();
        Console.ReadLine();
    }
}
*/