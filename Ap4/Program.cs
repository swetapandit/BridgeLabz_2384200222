using System;

class Program{
	static void Main(){
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Average of three numbers " + (num1 + num2 + num3)*(1.0)/3);
	}
}
