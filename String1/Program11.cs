/*using System;

class Program{
	static string RemoveDuplicate(string str){
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
		return res;
	}
	static string SortString(string st){
		char[] arr = new char[st.Length];
		char temp;
		for(int i=0; i<arr.Length-1; i++){
			for(int j=i+1; j<arr.Length-1; j++){
				if(arr[i]<arr[j]){
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}
		st = new string(arr);
		return st;
		
	}
	static void CheckAnagram(string str1, string str2){
		string s1 = RemoveDuplicate(str1);
		string s2 = RemoveDuplicate(str2);
		str1 = SortString(s1);
		str2 = SortString(s2);
		if(str1 == str2) Console.WriteLine("Anagram");
		else Console.WriteLine("Not Anagram");
	}

	static void Main(){
		string str1 = Console.ReadLine();
		string str2 = Console.ReadLine();
		CheckAnagram(str1,str2);
	}
}*/