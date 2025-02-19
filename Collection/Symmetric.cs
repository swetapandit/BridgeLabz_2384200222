/*using System;

namespace Collection
{
    public class SetOperations
    {
        public static void PrintSymmetricDifference(int[] set1, int[] set2)
        {
            Console.Write("Symmetric Difference: { ");

            foreach (int num in set1)
            {
                if (Array.IndexOf(set2, num) == -1)
                    Console.Write(num + " ");
            }

            foreach (int num in set2)
            {
                if (Array.IndexOf(set1, num) == -1)
                    Console.Write(num + " ");
            }

            Console.WriteLine("}");
        }

        public static void Main()
        {
            int[] set1 = { 1, 2, 3 };
            int[] set2 = { 3, 4, 5 };

            PrintSymmetricDifference(set1, set2);

            Console.ReadLine();
        }
    }
}
*/