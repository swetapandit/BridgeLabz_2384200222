using System;

public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0); // Get number of rows
        int cols = matrix.GetLength(1); // Get number of columns

        int low = 0, high = rows * cols - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int midValue = matrix[mid / cols, mid % cols]; // Convert mid index to 2D coordinates

            if (midValue == target)
                return true;
            else if (midValue < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return false; // Target not found
    }

    public static void Main()
    {
        Solution sol = new Solution();

        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements of the matrix row by row:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the target value to search for:");
        int target = Convert.ToInt32(Console.ReadLine());

        bool found = sol.SearchMatrix(matrix, target);
        if (found)
            Console.WriteLine("Target value found in the matrix.");
        else
            Console.WriteLine("Target value not found in the matrix.");
    }
}
