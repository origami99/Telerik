using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] size = ReadIntArr();
        int r = size[0];
        int c = size[1];

        int[][] matrix = new int[r][];
        for (int row = 0; row < r; row++)
        {
            matrix[row] = ReadIntArr();
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

    static int[] ReadIntArr()
    {
        string[] input = Console.ReadLine().Split();

        int[] nums = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            int n = 0;
            bool isSigned = false;
            int j = 0;
            if (input[i][0] == '-')
            {
                isSigned = true;
                j = 1;
            }

            for (; j < input[i].Length; j++)
            {
                n = n * 10 + (input[i][j] - '0');
            }

            if (isSigned)
                nums[i] = -n;
            else
                nums[i] = n;
        }

        return nums;
    }

    private static int GetSum(int[][] matrix, int row, int col)
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            int subRow = row + i;

            for (int j = 0; j < 3; j++)
            {
                int subCol = col + j;
                sum += matrix[subRow][subCol];
            }
        }

        return sum;
    }
}