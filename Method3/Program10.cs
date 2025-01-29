/*using System;

class MatrixOperations
{
    // Method to display a matrix
    public static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Method to add two matrices
    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    // Method to subtract two matrices
    public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    // Method to multiply two matrices
    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[2, 2];

        // Multiply rows of matrix1 with columns of matrix2
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1] * matrix2[1, j];
            }
        }
        return result;
    }

    // Method to transpose a matrix
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int[,] result = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }

    // Method to find the determinant of a 2x2 matrix
    public static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    static void Main()
    {
        // Initialize two 2x2 matrices
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        // Display matrices
        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        // Matrix addition
        int[,] addedMatrix = AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix 1 + Matrix 2:");
        DisplayMatrix(addedMatrix);

        // Matrix subtraction
        int[,] subtractedMatrix = SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix 1 - Matrix 2:");
        DisplayMatrix(subtractedMatrix);

        // Matrix multiplication
        int[,] multipliedMatrix = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix 1 * Matrix 2:");
        DisplayMatrix(multipliedMatrix);

        // Matrix transpose
        int[,] transposedMatrix = TransposeMatrix(matrix1);
        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(transposedMatrix);

        // Determinant of Matrix 1
        int det1 = Determinant2x2(matrix1);
        Console.WriteLine($"Determinant of Matrix 1: {det1}");
    }
}
*/