/*using System;

public class Program11
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c; // Calculate the discriminant

        if (delta > 0)
        {
            // Two real roots if delta is positive
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            // One real root if delta is zero
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            // No real roots if delta is negative
            return new double[] { };
        }
    }

    // Main method to get input and find the roots
    public static void Main(string[] args)
    {
        Console.Write("Enter the value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Find the roots using the method
        double[] roots = FindRoots(a, b, c);

        // Display the roots
        if (roots.Length == 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The equation has one real root: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"The equation has two real roots: {roots[0]} and {roots[1]}");
        }
    }
}
*/