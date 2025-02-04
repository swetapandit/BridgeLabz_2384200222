/*using System;

public class Book
{
    private static string libraryName = "Central Library";
    private readonly int isbn;

    private string title;
    private string author;

    public Book(string title, string author, int isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }

    public static string GetLibraryName()
    {
        return libraryName;
    }

    public void DisplayDetails()
    {
        if (this is Book)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Library Name: {GetLibraryName()}");
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book ISBN Number: {isbn}");
        }
        else Console.WriteLine("Invalid Book");
    }
}


class Program1
{
    public static void Main()
    {
        Console.WriteLine("---------Library Management System---------");

        Console.Write("Enter Book Title ");
        string title = Console.ReadLine();

        Console.Write("Enter Book Author ");
        string author = Console.ReadLine();

        Console.Write("Enter Book ISBN no. ");
        int isbn = Convert.ToInt32(Console.ReadLine());

        Book book = new Book(title, author, isbn);

        book.DisplayDetails();
        Console.ReadLine();
    }
}

*/