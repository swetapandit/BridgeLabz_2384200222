/*using System;
namespace Collection
{
	public class Program
	{
		public static void Reverse(int start, int end, List<int>list)
		{
			while (start <= end)
			{
				int temp = list[start];
				list[start] = list[end];
				list[end] = temp;
				start++;
				end--;
			}
		}
		
		public static void Main()
		{
			List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
			int k = 2;
			int n = list.Count;
			Reverse(0, k - 1, list);
			Reverse(k, n - 1, list);
			Reverse(0, n - 1, list);

			foreach(int l in list) Console.Write(l + " ");
			Console.ReadLine();
		}
	}
}

*/