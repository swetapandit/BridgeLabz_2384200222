/*using System;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public string ReleaseYear { get; set; }
    public double Rating { get; set; }

    public Movie(string title, string director, string releaseYear, double rating)
    {
        Title = title;
        Director = director;
        ReleaseYear = releaseYear;
        Rating = rating;
    }

    public void ShowMovieDetails()
    {
        Console.WriteLine($"{Title} | {Director} | {ReleaseYear} | Rating: {Rating}");
    }
}

class Node
{
    public Movie movie;
    public Node next;
    public Node prev;

    public Node(Movie movie)
    {
        this.movie = movie;
        this.next = null;
        this.prev = null;
    }
}

class LinkedList
{
    private Node head;
    private Node tail;
    public int Size { get; private set; }

    public LinkedList()
    {
        this.head = null;
        this.tail = null;
        this.Size = 0;
    }

    public void AddBeginning(Movie movie)
    {
        Node newNode = new Node(movie);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        this.Size++;
    }

    public void AddEnd(Movie movie)
    {
        Node newNode = new Node(movie);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
        }
        this.Size++;
    }

    public void AddPosition(int pos, Movie movie)
    {
        this.Size++;
        Node newNode = new Node(movie);
        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        if (pos <= 1)
        {
            AddBeginning(movie);
            return;
        }
        if (pos >= Size)
        {
            AddEnd(movie);
            return;
        }
        Node temp = head;
        int count = 1;
        while (count < pos - 1)
        {
            count++;
            temp = temp.next;
        }
        newNode.prev = temp;
        newNode.next = temp.next;
        temp.next.prev = newNode;
        temp.next = newNode;
    }

    public void DeleteByTitle(string title)
    {
        Node temp = head;
        while (temp != null && temp.movie.Title != title)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Movie not found!");
            return;
        }

        if (Size == 1)
        {
            Size--;
            head = null;
            return;
        }

        Size--;

        if (temp == head)
        {
            head = head.next;
            head.prev = null;
            return;
        }
        if (temp == tail)
        {
            tail = tail.prev;
            tail.next = null;
            return;
        }
        temp.prev.next = temp.next;
        temp.next.prev = temp.prev;
    }

    public void Display()
    {
        Node temp = head;
        if (head == null)
        {
            Console.WriteLine("No movies available!");
            return;
        }
        Console.WriteLine("Movies in Forward Order:");
        while (temp != null)
        {
            temp.movie.ShowMovieDetails();
            temp = temp.next;
        }
    }

    public void DisplayReverse()
    {
        Node temp = tail;
        if (tail == null)
        {
            Console.WriteLine("No movies available!");
            return;
        }
        Console.WriteLine("Movies in Reverse Order:");
        while (temp != null)
        {
            temp.movie.ShowMovieDetails();
            temp = temp.prev;
        }
    }

    public void SearchByDirector(string director)
    {
        Node temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.movie.Director.Contains(director))
            {
                temp.movie.ShowMovieDetails();
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("No movie found by this director.");
    }

    public void SearchByRating(double rating)
    {
        Node temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.movie.Rating >= rating)
            {
                temp.movie.ShowMovieDetails();
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("No movie found with this rating or higher.");
    }

    public void UpdateRating(string title, double newRating)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.movie.Title == title)
            {
                temp.movie.Rating = newRating;
                Console.WriteLine($"Rating for {title} updated to {newRating}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Movie not found!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Movie Management System");
            Console.WriteLine("1. Add Movie at Beginning");
            Console.WriteLine("2. Add Movie at End");
            Console.WriteLine("3. Add Movie at Specific Position");
            Console.WriteLine("4. Delete Movie by Title");
            Console.WriteLine("5. Display Movies in Forward Order");
            Console.WriteLine("6. Display Movies in Reverse Order");
            Console.WriteLine("7. Search Movies by Director");
            Console.WriteLine("8. Search Movies by Rating");
            Console.WriteLine("9. Update Movie Rating");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Movie Title: ");
                    string title1 = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director1 = Console.ReadLine();
                    Console.Write("Enter Release Year: ");
                    string year1 = Console.ReadLine();
                    Console.Write("Enter Rating: ");
                    double rating1 = Convert.ToDouble(Console.ReadLine());
                    list.AddBeginning(new Movie(title1, director1, year1, rating1));
                    break;

                case 2:
                    Console.Write("Enter Movie Title: ");
                    string title2 = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director2 = Console.ReadLine();
                    Console.Write("Enter Release Year: ");
                    string year2 = Console.ReadLine();
                    Console.Write("Enter Rating: ");
                    double rating2 = Convert.ToDouble(Console.ReadLine());
                    list.AddEnd(new Movie(title2, director2, year2, rating2));
                    break;

                case 3:
                    Console.Write("Enter Position to Insert Movie: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Movie Title: ");
                    string title3 = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director3 = Console.ReadLine();
                    Console.Write("Enter Release Year: ");
                    string year3 = Console.ReadLine();
                    Console.Write("Enter Rating: ");
                    double rating3 = Convert.ToDouble(Console.ReadLine());
                    list.AddPosition(pos, new Movie(title3, director3, year3, rating3));
                    break;

                case 4:
                    Console.Write("Enter Movie Title to Delete: ");
                    string title4 = Console.ReadLine();
                    list.DeleteByTitle(title4);
                    break;

                case 5:
                    list.Display();
                    break;

                case 6:
                    list.DisplayReverse();
                    break;

                case 7:
                    Console.Write("Enter Director Name to Search: ");
                    string directorSearch = Console.ReadLine();
                    list.SearchByDirector(directorSearch);
                    break;

                case 8:
                    Console.Write("Enter Minimum Rating to Search: ");
                    double ratingSearch = Convert.ToDouble(Console.ReadLine());
                    list.SearchByRating(ratingSearch);
                    break;

                case 9:
                    Console.Write("Enter Movie Title to Update Rating: ");
                    string titleToUpdate = Console.ReadLine();
                    Console.Write("Enter New Rating: ");
                    double newRating = Convert.ToDouble(Console.ReadLine());
                    list.UpdateRating(titleToUpdate, newRating);
                    break;

                case 10:
                    Console.WriteLine("Exiting the Movie Management System.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (choice != 10)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 10);
    }
}
*/