/*using System;

class Program2{
	static int NoOfDigits(int num){
		int cnt=0;
		while(num!= 0){
			num/=10;	
			 cnt++;
		}
		return cnt;
	}
	static int SumOfDigits(int[] digits){
		int sum=0;
		for(int i=0; i<digits.Length; i++) sum+=digits[i];
		return sum;
	}
	static int SumOfSquares(int[] digits){
		int sum=0;
		for(int i=0; i<digits.Length; i++) sum+= (int)Math.Pow(digits[i],2);
		return sum;
	}
	static bool HarshadNumber(int[] digits,int num){
		return num%SumOfDigits(digits) == 0;
	}
	static void FindFrequency(int num){
		int[] freq = new int[10];
		for(int i=0; i<10; i++){
			freq[num%10]++;
			num/=10;
		}
		for(int i=1; i<10; i++){
			if(freq[i]>=1)Console.WriteLine($"{i}\t{freq[i]}");
		}
	}
	static void Main(){
		int num = Convert.ToInt32(Console.ReadLine());
		int temp = num;
		int cnt = NoOfDigits(num);
		int[] digits = new int[cnt];
		Console.WriteLine($"Number of digits {cnt}");
		
		for(int i=0; i<cnt; i++) {
			digits[i] = temp%10;
			temp/=10;
		}

		Console.WriteLine("Elements of array is : ");
		for(int i=0; i<cnt; i++) {
			Console.Write($"{digits[i]} ");
		}

		Console.WriteLine();
		int sum = SumOfDigits(digits);
		Console.WriteLine($"Sum of digits is {sum}");		

		int sumSquare = SumOfSquares(digits);
		Console.WriteLine($"Sum of the squares {sumSquare}");
		
		if(HarshadNumber(digits, num)) Console.WriteLine($"{num} is Harshad Number");
		else Console.WriteLine($"{num} is not Harshad Number");
		
		FindFrequency(num);
	}
}*/