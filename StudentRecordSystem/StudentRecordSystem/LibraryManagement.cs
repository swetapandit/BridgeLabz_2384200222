/*using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Book ID: {BookID}, Title: {Title}, Author: {Author}, Genre: {Genre}, Available: {IsAvailable}");
    }
}

class Node
{
    public Book book;
    public Node next;
    public Node prev;

    public Node(Book book)
    {
        this.book = book;
        this.next = null;
        this.prev = null;
    }
}

class Library
{
    private Node head;
    private Node tail;
    private int count;

    public Library()
    {
        head = null;
        tail = null;
        count = 0;
    }

    // Add a book at the beginning
    public void AddBookBeginning(Book book)
    {
        Node newNode = new Node(book);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        count++;
    }

    // Add a book at the end
    public void AddBookEnd(Book book)
    {
        Node newNode = new Node(book);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    // Add a book at a specific position
    public void AddBookAtPosition(int pos, Book book)
    {
        if (pos <= 1)
        {
            AddBookBeginning(book);
            return;
        }
        if (pos > count)
        {
            AddBookEnd(book);
            return;
        }

        Node newNode = new Node(book);
        Node temp = head;
        for (int i = 1; i < pos - 1; i++)
        {
            temp = temp.next;
        }

        newNode.next = temp.next;
        newNode.prev = temp;
        temp.next.prev = newNode;
        temp.next = newNode;
        count++;
    }

    // Remove a book by Book ID
    public void RemoveBook(int bookID)
    {
        Node temp = head;

        while (temp != null && temp.book.BookID != bookID)
        {
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }

        if (temp == head) head = head.next;
        if (temp == tail) tail = tail.prev;
        if (temp.prev != null) temp.prev.next = temp.next;
        if (temp.next != null) temp.next.prev = temp.prev;

        count--;
        Console.WriteLine($"Book {bookID} removed successfully.");
    }

    // Search for a book by title or author
    public void SearchBook(string query)
    {
        Node temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.book.Title.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                temp.book.Author.Equals(query, StringComparison.OrdinalIgnoreCase))
            {
                temp.book.DisplayBook();
                found = true;
            }
            temp = temp.next;
        }

        if (!found)
        {
            Console.WriteLine("No book found!");
        }
    }

    // Update book availability
    public void UpdateAvailability(int bookID, bool status)
    {
        Node temp = head;

        while (temp != null)
        {
            if (temp.book.BookID == bookID)
            {
                temp.book.IsAvailable = status;
                Console.WriteLine($"Availability status updated for Book {bookID}.");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found!");
    }

    // Display books in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No books available!");
            return;
        }

        Node temp = head;
        Console.WriteLine("\nBooks in the library:");
        while (temp != null)
        {
            temp.book.DisplayBook();
            temp = temp.next;
        }
    }

    // Display books in reverse order
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No books available!");
            return;
        }

        Node temp = tail;
        Console.WriteLine("\nBooks in reverse order:");
        while (temp != null)
        {
            temp.book.DisplayBook();
            temp = temp.prev;
        }
    }

    // Count total number of books
    public int CountBooks()
    {
        return count;
    }
}

class Program
{
    public static void Main()
    {
        Library library = new Library();
        int choice, bookID;
        string title, author, genre;
        bool status;

        do
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book at Beginning");
            Console.WriteLine("2. Add Book at End");
            Console.WriteLine("3. Add Book at Position");
            Console.WriteLine("4. Remove Book");
            Console.WriteLine("5. Search Book");
            Console.WriteLine("6. Update Availability");
            Console.WriteLine("7. Display Books (Forward)");
            Console.WriteLine("8. Display Books (Reverse)");
            Console.WriteLine("9. Count Books");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Enter Book ID: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    library.AddBookBeginning(new Book(title, author, genre, bookID, true));
                    break;

                case 2:
                    Console.Write("Enter Book Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Enter Book ID: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    library.AddBookEnd(new Book(title, author, genre, bookID, true));
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Book Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Enter Book ID: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    library.AddBookAtPosition(pos, new Book(title, author, genre, bookID, true));
                    break;

                case 4:
                    Console.Write("Enter Book ID to Remove: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    library.RemoveBook(bookID);
                    break;

                case 5:
                    Console.Write("Enter Book Title or Author to Search: ");
                    string query = Console.ReadLine();
                    library.SearchBook(query);
                    break;

                case 6:
                    Console.Write("Enter Book ID to Update Availability: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Availability Status (true/false): ");
                    status = Convert.ToBoolean(Console.ReadLine());
                    library.UpdateAvailability(bookID, status);
                    break;

                case 7:
                    library.DisplayForward();
                    break;

                case 8:
                    library.DisplayReverse();
                    break;

                case 9:
                    Console.WriteLine($"Total Books in Library: {library.CountBooks()}");
                    break;

                case 10:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        } while (choice != 10);
    }
}
*/