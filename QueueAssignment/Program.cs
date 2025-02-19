/*using System;
using System.Collections.Generic;

namespace Collection
{
    public class QueueOperations
    {
        public static void ReverseQueue(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

            int front = queue.Dequeue();
            ReverseQueue(queue);
            queue.Enqueue(front);
        }

        public static void PrintQueue(Queue<int> queue)
        {
            Console.Write("Reversed Queue: [ ");
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");
        }

        public static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            ReverseQueue(queue);
            PrintQueue(queue);

            Console.ReadLine();
        }
    }
}
*/