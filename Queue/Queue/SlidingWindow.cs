/*using System;

class Node
{
    public int index;
    public Node next;
    public Node prev;

    public Node(int idx)
    {
        index = idx;
        next = null;
        prev = null;
    }
}

class Deque
{
    private Node front, rear;

    public Deque()
    {
        front = rear = null;
    }

    public void PushBack(int index)
    {
        Node newNode = new Node(index);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            newNode.prev = rear;
            rear = newNode;
        }
    }

    public void PopFront()
    {
        if (front != null)
        {
            front = front.next;
            if (front != null)
            {
                front.prev = null;
            }
            else
            {
                rear = null;
            }
        }
    }

    public void PopBack()
    {
        if (rear != null)
        {
            rear = rear.prev;
            if (rear != null)
            {
                rear.next = null;
            }
            else
            {
                front = null;
            }
        }
    }

    public int Front()
    {
        if (front != null)
        {
            return front.index;
        }
        return -1;
    }

    public int Back()
    {
        if (rear != null)
        {
            return rear.index;
        }
        return -1;
    }

    public bool IsEmpty()
    {
        return front == null;
    }
}

class SlidingWindowMaximum
{
    public static void FindMaxInWindows(int[] arr, int k)
    {
        Deque deque = new Deque();
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            // Remove elements that are out of this window
            if (!deque.IsEmpty() && deque.Front() < i - k + 1)
            {
                deque.PopFront();
            }

            // Remove elements from back that are smaller than the current element
            while (!deque.IsEmpty() && arr[deque.Back()] <= arr[i])
            {
                deque.PopBack();
            }

            // Insert current index
            deque.PushBack(i);

            // The first valid max appears after filling the first window
            if (i >= k - 1)
            {
                Console.Write(arr[deque.Front()] + " ");
            }
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        Console.WriteLine("Sliding Window Maximum:");
        FindMaxInWindows(arr, k);
        Console.ReadLine();
    }
}
*/