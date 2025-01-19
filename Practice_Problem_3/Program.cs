using System;

class Program{
	static void Main(){
		double cel = Convert.ToDouble(Console.ReadLine());
		double fah = (cel * 9/5)+32;
		Console.WriteLine("Equivalent Fahrenheit temp :"+fah);
	}
}