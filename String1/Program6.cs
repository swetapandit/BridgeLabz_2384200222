/*using System;

class Program{
	static int CountTarget(string str, string target){
		int cnt = 0;
		bool flag = true;
		if(target == "") return -1;
		for(int i=0; i<str.Length; i++){
			flag = true;
			for(int j=0; j<target.Length; j++){
				if(str[i+j]!=target[j]) {
					flag = false;
					break;
				}
			}
			if(flag) cnt++;
		}
		return cnt;
	}
	static void Main(){
		string str = Console.ReadLine();
		string target = Console.ReadLine();
		int count = CountTarget(str, target);
		Console.WriteLine($"No. of substring is {count}");
	}
}


str = this is a string     target = is
      i				  j

*/