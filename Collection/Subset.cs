using System;

namespace Collection
{
    public class SetOperations
    {
        public static void CheckSubset(int[] set1, int[] set2)
        {
            bool isSubset = true;

            foreach (int num in set1)
            {
                if (Array.IndexOf(set2, num) == -1)
                {
                    isSubset = false;
                    break;
                }
            }

            Console.WriteLine(isSubset ? "true" : "false");
        }

        public static void Main()
        {
            int[] set1 = { 2, 3 };
            int[] set2 = { 1, 2, 3, 4 };

            CheckSubset(set1, set2);

            Console.ReadLine();
        }
    }
}
