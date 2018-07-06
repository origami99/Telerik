using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[,] matrix = new long[n, n];

        long sum = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = (long)Math.Pow(2, row + col);
                if (row >= col)
                {
                    sum += matrix[row, col];
                }
            }
        }

        Console.WriteLine(sum);
    }
}
