using System;

class Program2{
	
	public int CalAverage(){
		int marksMath = 94;
		int marksPhysics = 95;
		int marksChemistry = 96;
		return (marksMath + marksPhysics + marksChemistry)/3;
	}
	
	static void Main(){
		Program2 p = new Program2();
		int avg = p.CalAverage();
		Console.WriteLine($"Sam's average mark in PCM is {avg}");
	}	
}