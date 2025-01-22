using System;

class Program3{
	double kiloMeter = 10.8;
	public double DistanceConverter(){ // function created to convert the distance.
		return kiloMeter * 1.6;
	}
	static void Main(){
		Program3 p = new Program3(); // instance created
		double result = p.DistanceConverter(); // Function Called using instance.
		Console.WriteLine($"The distance {p.kiloMeter} km in miles is {result}");//Data displayed
	}
}