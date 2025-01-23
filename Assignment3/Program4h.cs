using System;
class Program4h{
	 public static void FindMultiple(int number)
    	{
       	Console.WriteLine($"Multiples of {number} are:");
        	for (int i = 100; i >= 1; i--)  if (i % number == 0) Console.WriteLine(i);
        }
	static void Main(){
		int num = Convert.ToInt32(Console.ReadLine());
		FindMultiple(num);
	}
}