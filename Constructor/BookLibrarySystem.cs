/*using System;

class Book
{
    public string isbn;
    protected string title;
    private string author;

    // Constructor to initialize book details
    public Book(string isbn, string title, string author)
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
    }

    // Public method to get the author's name
    public string GetAuthor()
    {
        return author;
    }

    // Public method to set the author's name
    public void SetAuthor(string author)
    {
        author = author;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"ISBN: {isbn}, Title: {title}, Author: {author}");
    }
}

// Subclass EBook to access ISBN and Title, and demonstrate access modifiers
class EBook : Book
{
    public EBook(string isbn, string title, string author)
        : base(isbn, title, author) // Call to the base class constructor
    {
    }

    // Method to display EBook details (accessing protected and public members)
    public void DisplayEBookDetails()
    {
        Console.WriteLine($"EBook - ISBN: {isbn}, Title: {title}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Book object
        Book book1 = new Book("1234567890", "The Great Gatsby", "F. Scott Fitzgerald");
        book1.DisplayBookDetails();

        // Modifying the author name using public methods
        book1.SetAuthor("John Doe");
        Console.WriteLine($"Updated Author: {book1.GetAuthor()}");

        Console.WriteLine();

        // Creating an EBook object
        EBook eBook1 = new EBook("0987654321", "1984", "George Orwell");
        eBook1.DisplayEBookDetails();
        eBook1.DisplayBookDetails();  // Can access the protected title and public ISBN
    }
}
*/