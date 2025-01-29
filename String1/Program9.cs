/*using System;

class Program{
	static void FrequentChar(string str){
		char[] arr = new char[256];
		string ans = "";
		int prevMax = -1;
		int curMax = -1;
		for(int i=0; i<str.Length; i++){
			arr[str[i]]++;
		}
		for(int i=0; i<arr.Length; i++){
			if(arr[i]> curMax) {
				curMax = arr[i];
				ans = "";
				ans += arr[str[i]];
			}
		}
		Console.WriteLine($"Maximum occurence {curMax} {ans}");
	}
	static void Main(){
		string str = Console.ReadLine();
		FrequentChar(str);
		
	}
}*/