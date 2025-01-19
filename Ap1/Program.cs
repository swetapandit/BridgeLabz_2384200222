using System;

class Program{
	static void Main(){
		double principal = Convert.ToDouble(Console.ReadLine());
		double rate = Convert.ToDouble(Console.ReadLine());
		int time = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine((principal * rate * time)/100);
	}
}
