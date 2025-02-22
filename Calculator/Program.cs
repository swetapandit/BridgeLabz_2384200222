using Calculator;

class Program
{
    static void Main()
    {
        Operation calculator = new Operation(2,2);

        Console.WriteLine("Add: " + calculator.Add());
        Console.WriteLine("Subtract: " + calculator.Subtract());
        Console.WriteLine("Multiply: " + calculator.Multiply());
        Console.WriteLine("Divide: " + calculator.Divide());
        Console.ReadLine();
    }
}
