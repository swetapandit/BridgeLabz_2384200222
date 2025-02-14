using System;

class Node
{
    public int index;
    public Node next;

    public Node(int idx)
    {
        index = idx;
        next = null;
    }
}

class Queue
{
    private Node front, rear;

    public Queue()
    {
        front = rear = null;
    }

    public void Enqueue(int index)
    {
        Node newNode = new Node(index);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
    }

    public void Dequeue()
    {
        if (front != null)
        {
            front = front.next;
            if (front == null)
            {
                rear = null;
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

    public bool IsEmpty()
    {
        return front == null;
    }
}

class CircularTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        int totalPetrol = 0, totalDistance = 0;
        int start = 0, surplus = 0;

        Queue queue = new Queue();

        for (int i = 0; i < n; i++)
        {
            totalPetrol += petrol[i];
            totalDistance += distance[i];
            surplus += petrol[i] - distance[i];

            if (surplus < 0)
            {
                surplus = 0;
                start = i + 1; // Reset the start point
            }

            queue.Enqueue(i);
        }

        // If total petrol is less than total distance, return -1 (not possible)
        if (totalPetrol < totalDistance)
        {
            return -1;
        }

        return start;
    }

    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startIndex = FindStartingPump(petrol, distance);

        if (startIndex != -1)
        {
            Console.WriteLine("Starting index: " + startIndex);
        }
        else
        {
            Console.WriteLine("Tour not possible");
        }
        Console.ReadLine();
    }
}
