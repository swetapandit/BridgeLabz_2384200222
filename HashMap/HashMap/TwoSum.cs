using System;

namespace TwoSumSolution
{
    class HashMap
    {
        private int[] keys;
        private int[] values;
        private bool[] occupied;
        private int size;

        public HashMap(int capacity)
        {
            size = capacity;
            keys = new int[size];
            values = new int[size];
            occupied = new bool[size];
        }

        private int GetIndex(int key)
        {
            if (key < 0) key = -key; // Handle negative keys
            return key % size;
        }

        public void Insert(int key, int value)
        {
            int index = GetIndex(key);

            while (occupied[index]) // Linear probing for collision handling
            {
                index = (index + 1) % size;
            }

            keys[index] = key;
            values[index] = value;
            occupied[index] = true;
        }

        public int Get(int key)
        {
            int index = GetIndex(key);

            while (occupied[index])
            {
                if (keys[index] == key)
                {
                    return values[index];
                }
                index = (index + 1) % size;
            }
            return -1;
        }

        public bool ContainsKey(int key)
        {
            int index = GetIndex(key);

            while (occupied[index])
            {
                if (keys[index] == key)
                {
                    return true;
                }
                index = (index + 1) % size;
            }
            return false;
        }
    }

    class TwoSumFinder
    {
        public static void FindTwoSumIndices(int[] arr, int target)
        {
            HashMap map = new HashMap(arr.Length * 2);

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];

                bool exists = map.ContainsKey(complement);
                if (exists)
                {
                    int index = map.Get(complement);
                    Console.WriteLine("Indices: (" + index + ", " + i + ")");
                    return;
                }

                map.Insert(arr[i], i);
            }

            Console.WriteLine("No such indices found.");
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;

        TwoSumSolution.TwoSumFinder.FindTwoSumIndices(arr, target);
        Console.ReadLine();
    }
}
