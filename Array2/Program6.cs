/*using System;
class Program6{
	static double GetBmi(double height, double weight){
		return weight/ (height*height);
	}
	static String GetStatus(double bmi){
	      if(bmi<18.4) return "Underweight";
	      else if(bmi<24.9) return "Normal";
	      else if(bmi<39.9) return "Overweight";
	      else return "Obese";
	} 
	static void Main()
	{
		// totol number of persons
		int personCount = Convert.ToInt32(Console.ReadLine());
		double [] height = new double[personCount];
		double [] weight = new double[personCount];
		double [] bmi = new double[personCount];
		String [] status = new String[personCount];
		for(int i=0; i<personCount; i++){
			height[i] = Convert.ToDouble(Console.ReadLine());
		  	weight[i] = Convert.ToDouble(Console.ReadLine());
		  	bmi[i] = GetBmi(height[i], weight[i]);
		  	status[i] = GetStatus( bmi[i] );
		}
		Console.WriteLine("Person\t Height\t Weight\t BMI\t Status");
		for(int i=0;i<personCount; i++){
		Console.WriteLine($"Person{i+1}\t {height[i]}\t {weight[i]}\t {bmi[i]:F2}\t {status[i]}");
		}
	}
}*/