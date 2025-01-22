using System;
class Program5{
 
	// Function created to calculate profit & Loss with its percentage.
	public void Distribute(){ 
		int pen = 14;
		int student = 3;
		int penDistributed = pen/student; // No. of pen is distributed per student
		int remainingPen = pen%student; // No. of per Left
		Console.WriteLine($"The Pen Per Student is {penDistributed} and the remaining pen not distributed is {remainingPen}"); 
	}

	static void Main(){
		Program5 p = new Program5();//Instance Created
		p.Distribute();//Function Called
	}
}