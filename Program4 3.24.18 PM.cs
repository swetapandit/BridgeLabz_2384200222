// using System;
// class Program4{
 
// 	// Function created to calculate profit & Loss with its percentage.
// 	public void Calculate(){ 
// 		int costPrice = 129;
// 		int sellingPrice = 191;
// 		// To show Cost Price and Selling Price
// 		Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}"); 

//            // Profit Calculation block
// 		if(costPrice < sellingPrice) { 
// 			int profit = sellingPrice - costPrice;
// 			double profitPercent = ((profit*(1.0)/costPrice)*100);
// 			Console.WriteLine($"The Profit is INR {profit} and Profit Percentage is INR {profitPercent}");
// 		}

//            // Loss Block
//    		else {
// 			int loss = costPrice - sellingPrice;
// 			double lossPercent = ((loss*(1.0)/costPrice)*100);
// 			Console.WriteLine($"The Loss is INR {loss} and Loss Percentage is INR {lossPercent}");
// 		}
// 	}

// 	static void Main(){
// 		Program4 p = new Program4();//Instance Created
// 		p.Calculate();//Function Called
// 	}
// }