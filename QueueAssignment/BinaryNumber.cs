/*using System;
using System.Collections.Generic;

namespace Collection
{
    public class QueueOperations
    {
        public static void GenerateBinaryNumbers(int N)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");

            for (int i = 0; i < N; i++)
            {
                string current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }

        public static void Main()
        {
            int N = 5;
            GenerateBinaryNumbers(N);

            Console.ReadLine();
        }
    }
}
*/