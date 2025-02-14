/*using System;

class PairWithGivenSum
{
    class KeyValuePair
    {
        public int Key;
        public int Value;
        public KeyValuePair Next;

        public KeyValuePair(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    class HashMap
    {
        private KeyValuePair[] buckets;

        public HashMap(int size)
        {
            buckets = new KeyValuePair[size];
        }

        private int GetIndex(int key)
        {
            if (key < 0) key = -key; // Handle negative keys
            return key % buckets.Length;
        }

        public void Insert(int key, int value)
        {
            int index = GetIndex(key);
            KeyValuePair newNode = new KeyValuePair(key, value);
            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else
            {
                KeyValuePair temp = buckets[index];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public bool ContainsKey(int key)
        {
            int index = GetIndex(key);
            KeyValuePair temp = buckets[index];
            while (temp != null)
            {
                if (temp.Key == key) return true;
                temp = temp.Next;
            }
            return false;
        }
    }

    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashMap map = new HashMap(arr.Length * 2);

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];
            if (map.ContainsKey(complement))
            {
                Console.WriteLine("Pair found: (" + complement + ", " + arr[i] + ")");
                return true;
            }
            map.Insert(arr[i], i);
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;

        if (!PairWithGivenSum.HasPairWithSum(arr, target))
        {
            Console.WriteLine("No pair found.");
        }
        Console.ReadLine();
    }
}
*/