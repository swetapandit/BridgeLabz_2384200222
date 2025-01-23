/*using System;
class Program4d{
	public void FindMaxHeight(int heightAmar, int heightAkbar, int heightAnthony){

		 // Find the tallest friend
        	if (heightAmar > heightAkbar && heightAmar > heightAnthony) Console.WriteLine("The tallest friend is Amar.");
        	else if (heightAkbar > heightAmar && heightAkbar > heightAnthony) Console.WriteLine("The tallest friend is Akbar.");
        	else Console.WriteLine("The tallest friend is Anthony.");
	}
	public void FindMaxAge(int ageAmar, int ageAkbar, int ageAnthony){
		 // Find the youngest friend
        	if (ageAmar < ageAkbar && ageAmar < ageAnthony) Console.WriteLine("The youngest friend is Amar.");
        	else if (ageAkbar < ageAmar && ageAkbar < ageAnthony) Console.WriteLine("The youngest friend is Akbar.");
        	else Console.WriteLine("The youngest friend is Anthony.");

	}
	static void Main(){
		int heightAmar = Convert.ToInt32(Console.ReadLine());
		int heightAkbar = Convert.ToInt32(Console.ReadLine());
		int heightAnthony = Convert.ToInt32(Console.ReadLine());
		
		int ageAmar = Convert.ToInt32(Console.ReadLine());
		int ageAkbar = Convert.ToInt32(Console.ReadLine());
		int ageAnthony = Convert.ToInt32(Console.ReadLine());

		Program4d p = new Program4d();
		p.FindMaxHeight(heightAmar,heightAkbar, heightAnthony);
		p.FindMaxAge(ageAmar,ageAkbar, ageAnthony);
	}
}*/