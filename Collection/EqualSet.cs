/*using System;

namespace Collection
{
    public class CheckSets
    {
        public static bool AreSetsEqual(int[] set1, int[] set2)
        {
            if (set1.Length != set2.Length) return false;

            // Check if every element in set1 exists in set2
            for (int i = 0; i < set1.Length; i++)
            {
                if (!Contains(set2, set1[i])) return false;
            }
            return true;
        }

        public static bool Contains(int[] arr, int key)
        {
            // Linear search to check if key exists in arr
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key) return true;
            }
            return false;
        }

        public static void Main()
        {
            int[] set1 = { 1, 2, 3 };
            int[] set2 = { 3, 2, 1 };

            Console.WriteLine(AreSetsEqual(set1, set2)); // Output: true
            Console.ReadLine();
        }
    }
}
*/