/*using System;

class Program{
	static void CompareString(string str1, string str2){
		bool flag = false;
		for(int i=0; i<Math.Min(str1.Length,str2.Length); i++){
			if(str1[i]>str2[i]) {
				Console.WriteLine($"{str2} comes before {str1} in lexicographical order ");
				break;
			}
			else {
				Console.WriteLine($"{str1} comes before {str2} in lexicographical order ");
				break;
			}
		}
	}
	static void Main(){
		string str1 = Console.ReadLine();
		string str2 = Console.ReadLine();
		CompareString(str1,str2);
	}
}*/