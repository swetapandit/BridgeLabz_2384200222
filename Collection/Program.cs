/*using System;
using System.Collections;

class Node
{
    public int Data;
    public Node Next;

    // Constructor to create a new node
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    // Function to insert a new node at the end
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Function to reverse the linked list
    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;

        while(current != null)
        {
            next = current.Next;
            current.Next = prev;

            prev = current;
            current = next;
        }
        head = prev;  // Set head to the new first node
    }

    // Function to display the linked list
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }

    
}

class Program
{
    static void BubbleSort(ArrayList list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((int)list[j] > (int)list[j + 1])  // Swap if current is greater than next
                {
                    int temp = (int)list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }

    static void Show(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Inserting nodes
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);
        list.Insert(50);

        Console.WriteLine("Original Linked List:");
        list.Display();

        // Reversing the linked list
        list.Reverse();

        Console.WriteLine("Reversed Linked List:");
        list.Display();


        //Arraylist

        ArrayList numbers = new ArrayList() { 42, 15, 8, 23, 4, 16, 9 };

        Console.WriteLine("Original ArrayList:");
        Show(numbers);

        BubbleSort(numbers);

        Console.WriteLine("Sorted ArrayList:");
        Show(numbers);
        Console.ReadLine();
    }
}
*/