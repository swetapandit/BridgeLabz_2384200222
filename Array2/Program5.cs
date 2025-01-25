/*using System;
class Program5{
	static void Main(){
		int n = Convert.ToInt32(Console.ReadLine());
		int dig = 0;
		int temp = n;
		while(temp > 0){
			dig++;
			temp /= 10;
			}
		int [] arr = new int[dig];
		temp = n;
		int ind = 0;
		while(temp > 0){
			arr[ind] = temp%10;
			temp /= 10;
			ind++;
		}
		for(int i=0;i<dig;i++){
			Console.Write($"{arr[i]}");
		}	
	}
}*/