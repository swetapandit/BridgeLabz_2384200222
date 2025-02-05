/*using System;
using System.Collections.Generic;

class Book
{
    private string title;
    private string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Getter methods
    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void Display()
    {
        Console.WriteLine($"Book: {GetTitle()}, Author: {GetAuthor()}");
    }
}

class Library
{
    private string name;
    private List<Book> books;  // Aggregation: Library ke pass ek List<Book> hai

    public Library(string name)
    {
        this.name = name;
        books = new List<Book>();  // Empty list initialize
    }

    // Getter method for library name
    public string GetName()
    {
        return name;
    }

    public void AddBook(Book book)
    {
        books.Add(book);  // Book ko library me add kar rahe hain
    }

    public void ShowBooks()
    {
        Console.WriteLine($"\nLibrary: {GetName()}");
        foreach (var book in books)
        {
            book.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Book Name ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the Book Name ");
        string author = Console.ReadLine();

        Console.WriteLine("Enter the Library Name ");
        string libraryName = Console.ReadLine();

        // Independent books
        Book b1 = new Book(title, author);
        Book b2 = new Book(title, author);
        Book b3 = new Book(title, author);

        // Creating libraries
        Library lib1 = new Library(libraryName);
        Library lib2 = new Library(libraryName);

        // Adding books to different libraries
        lib1.AddBook(b1);
        lib1.AddBook(b2);
        lib2.AddBook(b2);
        lib2.AddBook(b3);

        // Display books in each library
        lib1.ShowBooks();
        lib2.ShowBooks();
        Console.ReadLine();
    }
}
*/