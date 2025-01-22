using System;

class Program12
{
    // Method to convert weight from pounds to kilograms
    public void ConvertWeight()
    {
        // Take input for weight in pounds
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms
        double weightInKilograms = weightInPounds / 2.2;

        // Print the result
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKilograms:F2}");
    }

    static void Main()
    {
        // Create an instance of Program12 and call the method
        Program12 program = new Program12();
        program.ConvertWeight();
    }
}
