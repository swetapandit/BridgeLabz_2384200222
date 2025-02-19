/*using System;

namespace Collection
{
    public class Node
    {
        public char data;
        public Node next;

        public Node(char data)
        {
            this.data = data;
            next = null;
        }
    }

    public class LinkedList
    {
        public Node head;

        public void Insert(char data)
        {
            if (head == null) head = new Node(data);
            else
            {
                Node temp = head;
                while (temp.next != null) temp = temp.next;
                temp.next = new Node(data);
            }
        }

        public void FindNthFromEnd(int N)
        {
            Node slow = head, fast = head;

            // Move fast pointer N steps ahead
            for (int i = 0; i < N; i++)
            {
                if (fast == null)
                {
                    Console.WriteLine("N is larger than list size.");
                    return;
                }
                fast = fast.next;
            }

            // Move both slow and fast one step at a time
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            Console.WriteLine(slow.data);
        }
    }

    public class NthFromEnd
    {
        public static void Main()
        {
            LinkedList list = new LinkedList();
            list.Insert('A');
            list.Insert('B');
            list.Insert('C');
            list.Insert('D');
            list.Insert('E');

            list.FindNthFromEnd(2); // Output: D
            Console.ReadLine();
        }
    }
}
*/