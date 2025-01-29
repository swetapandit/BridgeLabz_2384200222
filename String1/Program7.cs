/*using System;

class Program{
	static void ToggleString(string str){
		string result = "";
		for(int i=0; i<str.Length; i++) {
			if(str[i]>='A' && str[i]<='Z') result += (char)(str[i] + 32);
			else if(str[i]>='a' && str[i]<='z') result += (char)(str[i] - 32);
			else result += str[i];
		}
		Console.WriteLine(result);
	}
	static void Main(){
		string str = Console.ReadLine();
		ToggleString(str);
	}
}*/