/*using System;

class Program5{
    // Main function 
    static void Main(String[] args)
    {
        if(args.Length != 3){
		Console.WriteLine("Enter the date in format MM DD YYYY");
		return; 
	}
	
	int m = Convert.ToInt32(args[0]);
	int d = Convert.ToInt32(args[1]);
	int y = Convert.ToInt32(args[2]);

	// Gregorian calendar formula
	int y0 = y - (14 - m)/12;
	int x = y0 + y0/4-y0/100 +y0/400;
	int m0 = m+12 * ((14-m)/12)-2;
	int d0=(d+x+(31*m0)/12)%7;

	Console.WriteLine($"The day of the week for {m}/{d}/{y} is: {d0}");
        Console.WriteLine("Where 0.Sunday\n1.Monday\n2.Tuesday\n3.Wednesday\n4.Thrusday\n5.Friday\n6.Saturday\n7.Sunday");
	
    }
}*/