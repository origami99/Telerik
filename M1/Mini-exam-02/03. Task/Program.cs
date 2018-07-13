using System;

class Program
{
    private static string[] size = Console.ReadLine().Split();
    public static int r = int.Parse(size[0]);
    public static int c = int.Parse(size[1]);
    public static long[,] matrix = new long[r, c];

    static void Main()
    {
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = (long)Math.Pow(2, row + col);
            }
        }

        int posRow = 0;
        int posCol = 0;
        long sum = matrix[0, 0];


        while (true)
        {
            while (!HitWall(posRow + 1, posCol + 1))
            {
                posRow++;
                posCol++;
                sum += matrix[posRow, posCol];
            }
            if (HitCorner(posRow, posCol)) break;

            while (!HitWall(posRow - 1, posCol + 1))
            {
                posRow--;
                posCol++;
                sum += matrix[posRow, posCol];
            }
            if (HitCorner(posRow, posCol)) break;

            while (!HitWall(posRow - 1, posCol - 1))
            {
                posRow--;
                posCol--;
                sum += matrix[posRow, posCol];
            }
            if (HitCorner(posRow, posCol)) break;

            while (!HitWall(posRow + 1, posCol - 1))
            {
                posRow++;
                posCol--;
                sum += matrix[posRow, posCol];
            }
            if (HitCorner(posRow, posCol)) break;
        }

        Console.WriteLine(sum);
    }

    private static bool HitWall(int posRow, int posCol)
    {
        return posRow < 0 || posRow >= r || posCol < 0 || posCol >= c;
    }

    private static bool HitCorner(int posRow, int posCol)
    {
        return (posRow == 0 && posCol == 0) || (posRow == 0 && posCol == c - 1) ||
               (posRow == r - 1 && posCol == 0) || (posRow == r - 1 && posCol == c - 1);
    }
}
