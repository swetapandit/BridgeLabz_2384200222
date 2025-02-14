/*using System;

class Node
{
    public int data;
    public int index;
    public Node next;

    public Node(int value, int idx)
    {
        data = value;
        index = idx;
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

    public void Push(int value, int index)
    {
        Node newNode = new Node(value, index);
        newNode.next = top;
        top = newNode;
    }

    public void Pop()
    {
        if (top != null)
        {
            top = top.next;
        }
    }

    public bool IsEmpty()
    {
        if (top == null)
        {
            return true;
        }
        return false;
    }

    public int PeekIndex()
    {
        if (top != null)
        {
            return top.index;
        }
        return -1;
    }

    public int PeekValue()
    {
        if (top != null)
        {
            return top.data;
        }
        return -1;
    }
}

class StockSpan
{
    public static void CalculateStockSpan(int[] prices, int[] span)
    {
        Stack stack = new Stack();

        for (int i = 0; i < prices.Length; i++)
        {
            // Pop elements while stack top price is less than or equal to current price
            while (!stack.IsEmpty() && stack.PeekValue() <= prices[i])
            {
                stack.Pop();
            }

            // Compute the span
            if (stack.IsEmpty())
            {
                span[i] = i + 1;
            }
            else
            {
                span[i] = i - stack.PeekIndex();
            }

            // Push current price and index onto the stack
            stack.Push(prices[i], i);
        }
    }

    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = new int[prices.Length];

        CalculateStockSpan(prices, span);

        Console.WriteLine("Stock Prices: ");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.Write(prices[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Stock Span: ");
        for (int i = 0; i < span.Length; i++)
        {
            Console.Write(span[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
*/