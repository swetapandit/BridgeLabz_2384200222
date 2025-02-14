/*using System;

class ZeroSumSubarrays
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
            if (key < 0) key = -key; // Handling negative keys
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

        public int Get(int key)
        {
            int index = GetIndex(key);
            KeyValuePair temp = buckets[index];
            while (temp != null)
            {
                if (temp.Key == key) return temp.Value;
                temp = temp.Next;
            }
            return -1;
        }
    }

    public static void FindZeroSumSubarrays(int[] arr)
    {
        HashMap map = new HashMap(arr.Length * 2);
        int sum = 0;

        map.Insert(0, -1);  // Case when subarray starts from index 0

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                int start = map.Get(sum);
                Console.WriteLine("Subarray found from index " + (start + 1) + " to " + i);
            }
            else
            {
                map.Insert(sum, i);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2 };
        ZeroSumSubarrays.FindZeroSumSubarrays(arr);
        Console.ReadLine();
    }
}
*/