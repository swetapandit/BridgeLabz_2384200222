/*using System;
namespace Sorting
{
	public class InsertionSort
	{
		public static void SortId(int[] id)
		{
			int n = id.Length;
			for(int i=1; i < n; i++)
			{
				int key = id[i];
				int j = i - 1;
				while(j>=0 && id[j] > key)
				{
					id[j + 1] = id[j];
					j--;
				}
				id[j + 1] = key;
			}
			for(int i = 0; i < n; i++)
			{
                Console.WriteLine(" " + id[i]);
            }
		}
		public static void Main()
		{
			int[] id = { 101, 203, 111, 222, 90 };
			SortId(id);
			Console.ReadLine();
		}
	}
	
}

*/