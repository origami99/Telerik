using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        BigInteger[][] matrix = new BigInteger[r][];

        for (int row = 0; row < r; row++)
        {
            matrix[row] = new BigInteger[c];

            for (int col = 0; col < c; col++)
            {
                int power = r - 1 - row + col;
                matrix[row][col] = (BigInteger)Math.Pow(2, power);
            }
        }

        int n = int.Parse(Console.ReadLine());
        int[] moves = Console.ReadLine().Split().Select(int.Parse).ToArray();

        BigInteger points = 0;
        int pRow = r - 1;
        int pCol = 0;

        for (int i = 0; i < n; i++)
        {
            int coeff = Math.Max(r, c);
            int moveRow = moves[i] / coeff;
            int moveCol = moves[i] % coeff;

            if (moveCol < pCol)
            {
                for (int col = pCol; col >= moveCol; col--)
                {
                    points += matrix[pRow][col];
                    matrix[pRow][col] = 0;
                    pCol = col;
                }
            }

            if (moveCol > pCol)
            {
                for (int col = pCol; col <= moveCol; col++)
                {
                    points += matrix[pRow][col];
                    matrix[pRow][col] = 0;
                    pCol = col;
                }
            }

            if (moveRow < pRow)
            {
                for (int row = pRow; row >= moveRow; row--)
                {
                    points += matrix[row][pCol];
                    matrix[row][pCol] = 0;
                    pRow = row;
                }
            }

            if (moveRow > pRow)
            {
                for (int row = pRow; row <= moveRow; row++)
                {
                    points += matrix[row][pCol];
                    matrix[row][pCol] = 0;
                    pRow = row;
                }
            }
        }

        Console.WriteLine(points);
    }
}
