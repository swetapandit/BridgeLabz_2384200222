/*using System;

class Program9{
	static void ConverTo1D(int[,] arr, int rows, int cols){
		int[] oneDArr = new int[rows*cols];
		int index = 0;
		for(int i=0; i<rows; i++){
			for(int j=0; j<cols; j++) {
				oneDArr[index] = arr[i,j];
				index++;
			}
		}
		for(int i=0; i<rows*cols; i++){
			Console.WriteLine(oneDArr[i]);
		}
	}
	static void Main(){
		int rows = Convert.ToInt32(Console.ReadLine());
		int cols = Convert.ToInt32(Console.ReadLine());		
		int[,] arr = new int[rows,cols];
		for(int i=0; i<rows; i++){
			for(int j=0; j<cols; j++) arr[i,j] = Convert.ToInt32(Console.ReadLine());
		}
		ConverTo1D(arr,rows,cols);
	}
}*/