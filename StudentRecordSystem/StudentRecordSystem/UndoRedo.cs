/*using System;

class Node
{
    public string TextState;
    public Node Prev;
    public Node Next;

    public Node(string text)
    {
        TextState = text;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private Node current;
    private Node head;
    private Node tail;
    private int maxHistory = 10;
    private int size = 0;

    public TextEditor()
    {
        current = null;
        head = null;
        tail = null;
    }

    // Add a new text state (like typing or performing an action)
    public void AddState(string text)
    {
        Node newNode = new Node(text);

        // If we are at some point in history and we type something new, we erase the forward history
        if (current != null)
            current.Next = null;

        newNode.Prev = current;
        if (current != null)
            current.Next = newNode;

        current = newNode;

        if (head == null) head = current;
        tail = current;

        size++;

        // Remove old history if exceeding max history limit
        if (size > maxHistory)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    // Undo function - move to the previous state
    public void Undo()
    {
        if (current == null || current.Prev == null)
        {
            Console.WriteLine("Undo not possible.");
            return;
        }
        current = current.Prev;
    }

    // Redo function - move to the next state
    public void Redo()
    {
        if (current == null || current.Next == null)
        {
            Console.WriteLine("Redo not possible.");
            return;
        }
        current = current.Next;
    }

    // Display the current state of text
    public void DisplayCurrentState()
    {
        if (current == null)
        {
            Console.WriteLine("No text state available.");
            return;
        }
        Console.WriteLine($"Current Text: {current.TextState}");
    }
}

class Program
{
    public static void Main()
    {
        TextEditor editor = new TextEditor();
        int choice;
        string textInput;

        do
        {
            Console.WriteLine("\nText Editor with Undo/Redo");
            Console.WriteLine("1. Type/Add Text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Show Current Text");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter new text: ");
                    textInput = Console.ReadLine();
                    editor.AddState(textInput);
                    break;

                case 2:
                    editor.Undo();
                    break;

                case 3:
                    editor.Redo();
                    break;

                case 4:
                    editor.DisplayCurrentState();
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        } while (choice != 5);
    }
}
*/
