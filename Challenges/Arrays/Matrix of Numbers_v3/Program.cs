using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n * n; i++)
            matrix[i / n, i % n] = i / n + i % n + 1;

        Printing(matrix);
    }

    private static void Printing(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
