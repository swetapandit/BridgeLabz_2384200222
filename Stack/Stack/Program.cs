using System;

class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

class Stack
{
    private Node top;
    public Stack()
    {
        top = null;
    }
    // push method
    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.next = top;
        top = newNode;
    }
    // Display method
    public void Display()
    {
        Node temp = top;
        while(temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
        Console.WriteLine("Stack Empty");
    }

    // Pop method
    public int Pop()
    {
        Node temp = top;
        if (IsEmpty()) return -1;

        top = top.next;
        return temp.data;
    }

    // Peek Method
    public int Peek()
    {
        if (top == null) return -1;
        return top.data;
    }
    // IsEmpty Method
    public bool IsEmpty()
    {
        if (top == null) return true;
        else return false;
    }

    //Count Method
    public int Count()
    {
        Node temp = top;
        int cnt = 0;
        while(temp != null)
        {
            cnt++;
            temp = temp.next;
        }
        return cnt;
    }

    public void Show()
    {
        Push(10);
        Push(20);
        Push(30);
        Display();
        int newTop = Pop();
        if (newTop == -1) Console.WriteLine("The Stack is Empty");
        else Console.WriteLine("Popped Element is: " + newTop);
        Console.WriteLine("Number of Node: " + Count());
        if (Peek() == -1) Console.WriteLine("The Stack is Empty");
        else Console.WriteLine("Peek Element is: " + Peek());
        Console.WriteLine("Number of Node: " + Count());
        Delete();
        Display();

    }

    // Delete Whole Stack
    public void Delete()
    {
        int cnt = Count();
        while (cnt-- > 0) Pop();
        Console.WriteLine("Data deleted");
    }
}

class Program
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Show();
        Console.ReadLine();
    }
}