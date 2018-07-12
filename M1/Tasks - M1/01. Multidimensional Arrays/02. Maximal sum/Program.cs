using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(size[0]);
        int c = int.Parse(size[1]);

        int[][] matrix = new int[r][];
        for (int row = 0; row < r; row++)
        {
            matrix[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        }

        int maxSum = int.MinValue;

        for (int row = 0; row < r - 2; row++)
        {
            for (int col = 0; col < c - 2; col++)
            {
                int sum = GetSum(matrix, row, col);

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }

    public static int GetSum(int[][] matrix, int row, int col)
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += matrix[row + i][col + j];
            }
        }

        return sum;
    }
}