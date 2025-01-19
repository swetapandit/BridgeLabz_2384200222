using System;

class Program{
	static void Main(){
		int radius = Convert.ToInt32(Console.ReadLine());
		int height = Convert.ToInt32(Console.ReadLine());
		double volume = 3.14 * radius * radius * height;
		Console.WriteLine("Volume of the Cylinder " + volume);
	}
}
