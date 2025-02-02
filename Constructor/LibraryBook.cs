/*using System;
using System.Diagnostics;

class LibraryBook
{
    private string title;
    private string author;
    private double price;
    private bool isAvailable;

    // Parameterized Constructor
    public LibraryBook(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = true;  // By default, book is available
    }

    // Method to borrow a book
    public void BorrowBook()
    {
        if (this.isAvailable)
        {
            this.isAvailable = false;
            Console.WriteLine($"'{this.title}' has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{this.title}' is already borrowed.");
        }
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {this.title}, Author: {this.author}, Price: {this.price:C}, Available: {this.isAvailable}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the book name ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the book Author ");
        string author = Console.ReadLine();

        Console.WriteLine("Enter the book Price ");
        double price = Convert.ToDouble(Console.ReadLine());


        LibraryBook lb = new LibraryBook(title, author, price);
        lb.BorrowBook();
        lb.DisplayDetails();

        Console.ReadLine();
    }
}
*/