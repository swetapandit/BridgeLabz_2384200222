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
	static bool IsDuckNumber(int[] digits){
		for(int i=0; i<digits.Length; i++) if(digits[i]!=0) return true;
		return false;
	}
	static bool IsArmstrong(int[] digits,int num){
		int sum=0;
		for(int i=0; i<digits.Length; i++) {
			sum +=(int) Math.Pow(digits[i],digits.Length);
		}
		if(sum == num) return true;
		else return false;
	}
	static int[] FindMin(int[] digits){
		int min = int.MaxValue;
		int secMin = int.MaxValue;
		int[] arr = new int[2];
		foreach(int digit in digits){
			if(digit < min) {
				secMin = min;
				min = digit;
			}
			else if(digit < secMin && digit > min) secMin = digit;
		}
		arr[0] = min;
		arr[1] = secMin;
		return arr;
	}
	static int[] FindMax(int[] digits){
		int max = int.MinValue;
		int secMax = int.MinValue;
		foreach(int digit in digits){
			if(digit > max){
				secMax = max;
				max = digit;
			}
			else if(digit < max && digit > secMax) secMax = digit;	
		}
		int[] arr = new int[2];
		arr[0] = max;
		arr[1] = secMax;
		return arr;
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
		if(IsDuckNumber(digits)) Console.WriteLine($"{num} is Duck Number");
		else Console.WriteLine($"{num} is not Duct Number");
		
		if(IsArmstrong(digits,num)) Console.WriteLine($"{num} is Armstrong");
		else Console.WriteLine($"{num} is not Armstrong");
		
		int[] res = FindMin(digits);
		Console.WriteLine($"Minumum Value {res[0]} and Second Minimum Value {res[1]}");

		int[] maxArr = FindMax(digits);
		Console.WriteLine($"Maximum value {maxArr[0]} And second Maximum value {maxArr[1]}");
	}
}*/