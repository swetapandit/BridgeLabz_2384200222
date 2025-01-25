/*using System;
class Program10{
	static void Main()
	{	  
		int num = Convert.ToInt32(Console.ReadLine());
		int [] arr = new int[10];
		while(num!=0){
		  	arr[num%10]++;
		  	num /= 10;
		}
		Console.WriteLine("Digit\t Frequency");
		for(int i=0;i<10;i++){
			if(arr[i]>0)
		  	Console.WriteLine($"  {i}\t    {arr[i]}");
		}
	}
}*/