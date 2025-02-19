/*using System;
using System.Collections;
namespace Collection
{
	public class CountElement
	{
		Dictionary<string, int> d = new Dictionary<string, int>();
        public void LetsCount(List<string> list)
        {
			foreach(string s in list)
			{
				if (d.ContainsKey(s)) d[s]++;
				else d[s] = 1;
			}
        }
		public void Display()
		{
			foreach (var v in d) Console.Write($"{v.Key}: {v.Value}, ");
		}
    }

	public class Public
	{
		public static void Main()
		{
			List<String> list = new List<string>() { "apple", "banana", "apple", "orange" };
			CountElement ce = new CountElement();
			ce.LetsCount(list);
			ce.Display();
			Console.ReadLine();
		}
	}
}

*/