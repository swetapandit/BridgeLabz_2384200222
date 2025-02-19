/*using System;

namespace Collection
{
    public class SetOperations
    {
        public static void PrintUnion(int[] set1, int[] set2)
        {
            Console.Write("Union: ");
            foreach (int num in set1) Console.Write(num + " ");

            foreach (int num in set2)
            {
                if (Array.IndexOf(set1, num) == -1) Console.Write(num + " ");
            }
        }

        public static void PrintIntersection(int[] set1, int[] set2)
        {
            Console.Write("Intersection: ");
            foreach (int num in set1)
            {
                if (Array.IndexOf(set2, num) != -1) Console.Write(num + " ");
            }
        }

        public static void Main()
        {
            int[] set1 = { 1, 2, 3 };
            int[] set2 = { 3, 4, 5 };

            PrintUnion(set1, set2);
            PrintIntersection(set1, set2);

            Console.ReadLine();
        }
    }
}
*/