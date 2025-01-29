/*using System;

class Program
{
	static void FindLongestWord(string str){
		string temp = "";
		string word = "";
		int prevMax = -1;
		int curMax = -1;
		for(int i=0; i<str.Length; i++){
			if(str[i]==' ') {
				curMax = Math.Max(prevMax,temp.Length);
				if(curMax>prevMax){
					word=temp;
					prevMax=curMax;
				}
				temp = "";
				continue;
			}
			else temp += str[i];
		}
		curMax = Math.Max(prevMax,temp.Length);
		if(curMax>prevMax){
			word=temp;
			prevMax=curMax;
		}		
		Console.WriteLine(word);
	}
	static void Main(){
		string str = Console.ReadLine();
		FindLongestWord(str);
	}
}
*/