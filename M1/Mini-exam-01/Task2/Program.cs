using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // start - 10:26

        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[n]; 
        }

        int counter = 1;
        for (int i = 0; i < n; i++) // !IsMatrixFull(matrix)
        {
            for (int j = i; j < n - i; j++)
            {
                matrix[i][j] = counter;
                counter++;
            }

            for (int j = i + 1; j < n - i; j++)
            {
                matrix[j][n - i - 1] = counter;
                counter++;
            }

            for (int j = i + 1; j < n - i; j++)
            {
                matrix[n - i - 1][n - j - 1] = counter;
                counter++;
            }

            for (int j = i + 1; j < n - i - 1; j++)
            {
                matrix[n - j - 1][i] = counter;
                counter++;
            }
        }

        foreach (int[] row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }

        // end: 11:27
    }

    //private static bool IsMatrixFull(int[][] matrix)
    //{
    //    return matrix.All(x => x.Count(n => n == 0) == 0);
    //}
}
