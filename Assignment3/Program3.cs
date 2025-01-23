// using System;
// class Program3{
// 	public bool IsPrime(int num){
// 		for(int i=2; i<=Math.Sqrt(num); i++) if(num % i == 0) return false;
// 		return true;
// 	}
// 	static void Main(){
// 		int num = Convert.ToInt32(Console.ReadLine());
// 		Program3 p = new Program3();
// 		if(p.IsPrime(num)) Console.WriteLine($"{num} is Prime");
// 		else Console.WriteLine($"{num} is not Prime");
// 	}
// }