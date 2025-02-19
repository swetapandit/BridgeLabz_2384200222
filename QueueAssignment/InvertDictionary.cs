/*using System;
using System.Collections.Generic;

namespace Collection
{
    public class MapOperations
    {
        public static void InvertMap(Dictionary<string, int> originalMap)
        {
            Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

            foreach (var item in originalMap)
            {
                if (!invertedMap.ContainsKey(item.Value))
                {
                    invertedMap[item.Value] = new List<string>();
                }
                invertedMap[item.Value].Add(item.Key);
            }

            Console.WriteLine("Inverted Map:");
            foreach (var item in invertedMap)
            {
                Console.Write($"{item.Key}=[");
                foreach (var key in item.Value)
                {
                    Console.Write(key + " ");
                }
                Console.WriteLine("]");
            }
        }

        public static void Main()
        {
            Dictionary<string, int> originalMap = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

            InvertMap(originalMap);

            Console.ReadLine();
        }
    }
}
*/