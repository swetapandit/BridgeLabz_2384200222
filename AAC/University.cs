using System;
using System.Collections.Generic;

class Product
{
    public string name;
    public double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
        Console.WriteLine($"Product {this.name} (₹{this.price}) Added");
    }

    ~Product()
    {
        Console.WriteLine($"Product {name} Removed");
    }
}

class Order
{
    public int orderId;
    public List<Product> products; // Aggregation: Order holds Products
    public Customer customer; // Association: Order is linked to a Customer

    public Order(int id, Customer customer)
    {
        this.orderId = id;
        this.customer = customer;
        products = new List<Product>();
        Console.WriteLine($"Order {orderId} Created for {customer.name}");
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Product {product.name} added to Order {orderId}");
    }

    public void ShowOrderDetails()
    {
        Console.WriteLine($"\nOrder {orderId} Summary:");
        Console.WriteLine($"Customer: {customer.name}");
        Console.WriteLine("Products:");
        foreach (Product product in products)
        {
            Console.WriteLine($"- {product.name} (₹{product.price})");
        }
    }

    ~Order()
    {
        Console.WriteLine($"Order {orderId} Deleted");
    }
}

class Customer
{
    public string name;
    public List<Order> orders; // Association: Customer has multiple Orders

    public Customer(string name)
    {
        this.name = name;
        orders = new List<Order>();
        Console.WriteLine($"Customer {this.name} Created");
    }

    public void PlaceOrder(Order order)
    {
        orders.Add(order);
    }

    public void ShowOrders()
    {
        Console.WriteLine($"\nCustomer {name} Orders:");
        foreach (Order order in orders)
        {
            Console.WriteLine($"- Order {order.orderId}");
        }
    }

    ~Customer()
    {
        Console.WriteLine($"Customer {name} Deleted");
    }
}

class Program
{
    static void Main()
    {
        // Customers
        Customer c1 = new Customer("Aarushi");
        Customer c2 = new Customer("Rohan");

        // Products
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Phone", 20000);
        Product p3 = new Product("Headphones", 3000);

        // Orders
        Order o1 = new Order(101, c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Order o2 = new Order(102, c2);
        o2.AddProduct(p3);

        // Placing Orders
        c1.PlaceOrder(o1);
        c2.PlaceOrder(o2);

        // Show Details
        o1.ShowOrderDetails();
        o2.ShowOrderDetails();

        c1.ShowOrders();
        c2.ShowOrders();

        Console.ReadLine();
        // Deleting Objects
        o1 = null;
        o2 = null;
        c1 = null;
        c2 = null;
        GC.Collect(); // Force garbage collection
    }
}
