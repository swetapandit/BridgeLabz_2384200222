using System;
class Program16{
	public void MaxHandshakes(){
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		int maxHandshakes = (numberOfStudents*(numberOfStudents-1))/2;
		Console.WriteLine($"Number of possible Handshakes is {maxHandshakes}");
	}
	static void Main(){
		Program16 p = new Program16();
		p.MaxHandshakes();
	}
}