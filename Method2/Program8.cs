/*using System;

class Program2
{
    static void Main(string[] args)
    {
        // Declare arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];
        
        // Take input from the user
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of friend {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Enter height of friend {i + 1} (in meters): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Call functions to find the youngest and tallest
        int youngestIndex = FindYoungest(ages);
        double tallestHeight = FindTallest(heights);

        // Display the results
        Console.WriteLine($"The youngest friend is friend {youngestIndex + 1} with age {ages[youngestIndex]}.");
        Console.WriteLine($"The tallest friend has a height of {tallestHeight} meters.");
    }

    // Function to find the index of the youngest friend
    static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    // Function to find the tallest friend's height
    static double FindTallest(double[] heights)
    {
        double tallestHeight = heights[0];
        foreach (double height in heights)
        {
            if (height > tallestHeight)
            {
                tallestHeight = height;
            }
        }
        return tallestHeight;
    }
}*/