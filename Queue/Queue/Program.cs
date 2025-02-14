/*using System;

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
        while (temp != null)
        {
            cnt++;
            temp = temp.next;
        }
        return cnt;
    }
    


}

class Queue
{
    private Stack stack1;
    private Stack stack2;

    public Queue()
    {
        stack1 = new Stack();
        stack2 = new Stack();
    }

    public void Enqueue(int data)
    {
        stack1.Push(data);
    }

    public int Dequeue()
    {
        if(stack1.IsEmpty() && stack2.IsEmpty())
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        if (stack2.IsEmpty())
        {
            while (!stack1.IsEmpty()) stack2.Push(stack1.Pop());
        }
        return stack2.Pop();
    }

    public void Display()
    {
        if (stack1.IsEmpty() && stack2.IsEmpty())
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.Write("Queue elements: ");

        // Print elements from stack2 first (oldest elements)
        Stack tempStack = new Stack();
        while (!stack2.IsEmpty())
        {
            int val = stack2.Pop();
            Console.Write(val + " ");
            tempStack.Push(val);
        }

        // Restore stack2
        while (!tempStack.IsEmpty())
        {
            stack2.Push(tempStack.Pop());
        }

        // Print elements from stack1 (newer elements)
        Stack tempStack1 = new Stack();
        while (!stack1.IsEmpty())
        {
            int val = stack1.Pop();
            tempStack1.Push(val);
        }

        while (!tempStack1.IsEmpty())
        {
            int val = tempStack1.Pop();
            Console.Write(val + " ");
            stack1.Push(val);
        }

        Console.WriteLine();
    }

    public void Show()
    {
        Enqueue(10);
        Enqueue(20);
        Enqueue(30);
        Display();
        Dequeue();
        Display();

    }
}

class Program
{
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Show();
        Console.ReadLine();
    }
}*/