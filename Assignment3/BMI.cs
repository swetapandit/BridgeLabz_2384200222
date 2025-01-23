// using System;

// class BMI{
// 	public double CalcBmi(double weight, double height){
// 		double result = weight/(height*height);
// 		return result;
// 	}
// 	public String CheckBmi(double result)
// 	{
// 		if(result>=40.0) return "Obese";
// 		else if(result>=25.0 && result<40.0) return "Overweight";
// 		else if(result>=18.5 && result<25.0) return "Normal";
// 		else return "Underweight";	
// 	}
// 	static void Main(){		
// 		double weight = Convert.ToDouble(Console.ReadLine());
// 		double height = Convert.ToDouble(Console.ReadLine());
// 		height /=100;
// 		BMI b = new BMI();
// 		double result = b.CalcBmi(weight,height);
// 		Console.WriteLine(b.CheckBmi(result));
		
// 	}
// }