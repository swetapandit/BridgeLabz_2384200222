/*using System;
using System.Collections.Generic;

namespace Collection
{
    public class SetOperations
    {
        public static void PrintSortedSet(HashSet<int> set)
        {
            List<int> sortedList = new List<int>(set);
            sortedList.Sort();

            Console.Write("Sorted List: [ ");
            foreach (int num in sortedList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");
        }

        public static void Main()
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

            PrintSortedSet(set);

            Console.ReadLine();
        }
    }
}
*/