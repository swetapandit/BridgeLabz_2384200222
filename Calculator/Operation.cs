using System;
namespace Calculator
{
    
	public class Operation
	{
        private int a, b;
        public Operation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Add()
        {
            return a + b;
        }

        // Method to subtract two numbers
        public int Subtract()
        {
            return a - b;
        }

        // Method to multiply two numbers
        public int Multiply()
        {
            return a * b;
        }

        // Method to divide two numbers
        public int Divide()
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}

