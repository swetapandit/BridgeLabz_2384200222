/*using System;
class Program7{
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
		double [][] personData = new double[personCount][];
		String [] status = new String[personCount];
		for(int i=0; i<personCount; i++){
		// Initialize each row in the jagged array
			personData[i] = new double[3];
		  	personData[i][0] = Convert.ToDouble(Console.ReadLine());
		  	personData[i][1] = Convert.ToDouble(Console.ReadLine());
		  	personData[i][2] = GetBmi(personData[i][0], personData[i][1]);
		  	status[i] = GetStatus( personData[i][2] );
		}
		Console.WriteLine("Person\t Height\t Weight\t BMI\t Status");
		for(int i=0;i<personCount; i++){
			Console.WriteLine($"Person{i+1}\t {personData[i][0]}\t {personData[i][1]}\t {personData[i][2]:F2}\t {status[i]}");
		}
	}
}*/