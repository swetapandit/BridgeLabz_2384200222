using System;

class Book1
{
    private string title;
    private string author;

    public Book1(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

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
        Console.WriteLine($"Book Title: {title}");
        Console.WriteLine($"Book Author: {author}");
    }
}

class Library
{
    private string libraryName;
    private List<Book1> book1s;

    public Library(string libraryName)
    {
        this.libraryName = libraryName;
        book1s = new List<Book1>();
    }

    public string GetLibraryName()
    {
        return libraryName;
    }

    public void AddBook(Book1 book1)
    {
        book1s.Add(book1);
    }

    public void Show()
    {
        Console.WriteLine("Displaying data");
        foreach(var book in book1s)
        {
            book.Display();
        }
    }
}

class Program1
{
    public static void Main()
    {
        //Console.WriteLine("Enter the Book Name: ");
        //string title = Console.ReadLine();

        //Console.WriteLine("Enter the Book author: ");
        //string author = Console.ReadLine();

        //Console.WriteLine("Enter the Library Name: ");
        //string libraryName = Console.ReadLine();

        Book1 book1 = new Book1("Book1", "Author1");
        Book1 book2 = new Book1("Book2", "Author2");
        Book1 book3 = new Book1("Book3", "Author3");

        Library lib1 = new Library("Library One");
        Library lib2 = new Library("Library two");

        lib1.AddBook(book1);
        lib2.AddBook(book2);
        lib1.AddBook(book3);
        lib1.AddBook(book2);

        Console.WriteLine($"{lib1.GetLibraryName()}");
        lib1.Show();
        Console.WriteLine($"----------------------------");
        Console.WriteLine($"{lib2.GetLibraryName()}");
        lib2.Show();
        Console.ReadLine();
    }
}