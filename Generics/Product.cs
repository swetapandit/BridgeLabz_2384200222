/*using System;
using System.Collections.Generic;

// Base class for product categories
abstract class ProductCategory
{
    public string CategoryName { get; }

    protected ProductCategory(string categoryName)
    {
        CategoryName = categoryName;
    }
}

// Book category
class BookCategory : ProductCategory
{
    public BookCategory() : base("Books") { }
}

// Clothing category
class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("Clothing") { }
}

// Generic Product class
class Product<T> where T : ProductCategory
{
    public string Name { get; }
    public double Price { get; private set; }
    public T Category { get; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {Name} | Category: {Category.CategoryName} | Price: ${Price}");
    }

    // Generic method to apply a discount
    public void ApplyDiscount(double percentage)
    {
        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid discount percentage!");
            return;
        }
        Price -= (Price * percentage / 100);
    }
}

// Product catalog
class ProductCatalog<T> where T : ProductCategory
{
    private List<Product<T>> products = new List<Product<T>>();

    public void AddProduct(Product<T> product)
    {
        products.Add(product);
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("\nProduct Catalog:");
        foreach (var product in products)
        {
            product.DisplayProduct();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create product catalogs
        ProductCatalog<BookCategory> bookCatalog = new ProductCatalog<BookCategory>();
        ProductCatalog<ClothingCategory> clothingCatalog = new ProductCatalog<ClothingCategory>();

        // Create products
        Product<BookCategory> book1 = new Product<BookCategory>("C# Programming", 50, new BookCategory());
        Product<BookCategory> book2 = new Product<BookCategory>("Data Structures", 60, new BookCategory());

        Product<ClothingCategory> shirt = new Product<ClothingCategory>("Formal Shirt", 40, new ClothingCategory());
        Product<ClothingCategory> jeans = new Product<ClothingCategory>("Denim Jeans", 70, new ClothingCategory());

        // Add products to catalog
        bookCatalog.AddProduct(book1);
        bookCatalog.AddProduct(book2);
        clothingCatalog.AddProduct(shirt);
        clothingCatalog.AddProduct(jeans);

        // Apply discounts
        book1.ApplyDiscount(10);  // 10% discount on C# Programming book
        jeans.ApplyDiscount(15);  // 15% discount on Denim Jeans

        // Display catalogs
        bookCatalog.DisplayCatalog();
        clothingCatalog.DisplayCatalog();
        Console.ReadLine();
    }
}
*/