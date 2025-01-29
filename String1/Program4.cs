/*using System;

class Program{
	static void RemoveDuplicate(string str){
		string res = "";
		bool flag = false;
		for(int i=0; i< str.Length; i++){
			flag = true;
			for(int j=0; j< res.Length; j++){
				if(str[i]==res[j]){
					flag = false;
					break;
				}
			}
			if(flag) res += str[i];
		}
		Console.WriteLine(res);
	}
	static void Main(){
		string str = Console.ReadLine();
		RemoveDuplicate(str);
	}
}
*/