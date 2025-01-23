using System;

class Program6{
	
	static void Calculate(int first, int second, string op){
			switch(op){
				case "+": Console.WriteLine(first+second); break;
				case "-": Console.WriteLine(first-second); break;
				case "*": Console.WriteLine(first*second); break;
				case "/": Console.WriteLine(first/second); break;
				default: Console.WriteLine("Invalid Input"); break;
				}
	}
	
    // Main function 
    static void Main(String[] args)
    {
		Console.WriteLine("Enter the number of times these operation you want");
		int num = Convert.ToInt32(Console.ReadLine());
		while(num-- > 0) {
		int first = Convert.ToInt32(Console.ReadLine());
		int second = Convert.ToInt32(Console.ReadLine());
		String op = Console.ReadLine();
		Calculate(first, second, op);
		}
    }
}
