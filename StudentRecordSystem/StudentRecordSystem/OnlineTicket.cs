/*using System;

public class Ticket
{
    public int TicketID { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public string SeatNumber { get; set; }
    public DateTime BookingTime { get; set; }

    public Ticket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
    }

    public void ShowTicketDetails()
    {
        Console.WriteLine($"Ticket ID: {TicketID}, Customer: {CustomerName}, Movie: {MovieName}, Seat: {SeatNumber}, Booking Time: {BookingTime}");
    }
}

class Node
{
    public Ticket ticket;
    public Node next;

    public Node(Ticket ticket)
    {
        this.ticket = ticket;
        this.next = null;
    }
}

class CircularLinkedList
{
    private Node head;
    private Node tail;
    public int Size { get; private set; }

    public CircularLinkedList()
    {
        this.head = null;
        this.tail = null;
        this.Size = 0;
    }

    public void AddTicket(Ticket ticket)
    {
        Node newNode = new Node(ticket);
        if (head == null)
        {
            head = tail = newNode;
            tail.next = head; // Circular link
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
            tail.next = head; // Circular link
        }
        Size++;
    }

    public void RemoveTicketByID(int ticketID)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available to remove.");
            return;
        }

        Node temp = head;
        Node prev = null;

        // Check if the ticket to be removed is the first node
        if (head.ticket.TicketID == ticketID)
        {
            if (head == tail) // Only one ticket in the list
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                tail.next = head; // Update circular link
            }
            Size--;
            Console.WriteLine("Ticket removed successfully.");
            return;
        }

        // Traverse through the list to find the ticket to remove
        do
        {
            prev = temp;
            temp = temp.next;
            if (temp.ticket.TicketID == ticketID)
            {
                prev.next = temp.next;
                if (temp == tail)
                {
                    tail = prev; // Update the tail if the last node is removed
                }
                Size--;
                Console.WriteLine("Ticket removed successfully.");
                return;
            }
        } while (temp != head);

        Console.WriteLine("Ticket with given ID not found.");
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Node temp = head;
        do
        {
            temp.ticket.ShowTicketDetails();
            temp = temp.next;
        } while (temp != head);
    }

    public void SearchTicketByCustomerName(string customerName)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Node temp = head;
        bool found = false;
        do
        {
            if (temp.ticket.CustomerName.Contains(customerName))
            {
                temp.ticket.ShowTicketDetails();
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No ticket found for the given customer name.");
        }
    }

    public void SearchTicketByMovieName(string movieName)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Node temp = head;
        bool found = false;
        do
        {
            if (temp.ticket.MovieName.Contains(movieName))
            {
                temp.ticket.ShowTicketDetails();
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No ticket found for the given movie name.");
        }
    }

    public void CalculateTotalTickets()
    {
        Console.WriteLine($"Total number of booked tickets: {Size}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Online Ticket Reservation System");
            Console.WriteLine("1. Add Ticket Reservation");
            Console.WriteLine("2. Remove Ticket by ID");
            Console.WriteLine("3. Display All Tickets");
            Console.WriteLine("4. Search Ticket by Customer Name");
            Console.WriteLine("5. Search Ticket by Movie Name");
            Console.WriteLine("6. Calculate Total Booked Tickets");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Ticket ID: ");
                    int ticketID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Movie Name: ");
                    string movieName = Console.ReadLine();
                    Console.Write("Enter Seat Number: ");
                    string seatNumber = Console.ReadLine();
                    Console.Write("Enter Booking Time (yyyy-MM-dd HH:mm): ");
                    DateTime bookingTime = DateTime.Parse(Console.ReadLine());

                    Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
                    list.AddTicket(newTicket);
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to Remove: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    list.RemoveTicketByID(removeID);
                    break;

                case 3:
                    list.DisplayTickets();
                    break;

                case 4:
                    Console.Write("Enter Customer Name to Search: ");
                    string searchCustomer = Console.ReadLine();
                    list.SearchTicketByCustomerName(searchCustomer);
                    break;

                case 5:
                    Console.Write("Enter Movie Name to Search: ");
                    string searchMovie = Console.ReadLine();
                    list.SearchTicketByMovieName(searchMovie);
                    break;

                case 6:
                    list.CalculateTotalTickets();
                    break;

                case 7:
                    Console.WriteLine("Exiting the system.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (choice != 7)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 7);
    }
}
*/