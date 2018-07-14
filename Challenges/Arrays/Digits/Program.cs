using System;
using System.Linq;

public class Digits
{
    public const int ROW_LEN = 5;
    public const int COL_LEN = 3;

    private static readonly int[,] One = 
    {
        { 0, 0, 1 },
        { 0, 1, 1 },
        { 1, 0, 1 },
        { 0, 0, 1 },
        { 0, 0, 1 }
    };

    private static readonly int[,] Two = 
    {
        { 0, 1, 0 },
        { 1, 0, 1 },
        { 0, 0, 1 },
        { 0, 1, 0 },
        { 1, 1, 1 }
    };

    private static readonly int[,] Three =
    {
        { 1, 1, 1 },
        { 0, 0, 1 },
        { 0, 1, 1 },
        { 0, 0, 1 },
        { 1, 1, 1 }
    };

    private static readonly int[,] Four = 
    {
        { 1, 0, 1 },
        { 1, 0, 1 },
        { 1, 1, 1 },
        { 0, 0, 1 },
        { 0, 0, 1 }
    };

    private static readonly int[,] Five = 
    {
        { 1, 1, 1 },
        { 1, 0, 0 },
        { 1, 1, 1 },
        { 0, 0, 1 },
        { 1, 1, 1 }
    };

    private static readonly int[,] Six = 
    {
        { 1, 1, 1 },
        { 1, 0, 0 },
        { 1, 1, 1 },
        { 1, 0, 1 },
        { 1, 1, 1 }
    };

    private static readonly int[,] Seven =
    {
        { 1, 1, 1 },
        { 0, 0, 1 },
        { 0, 1, 0 },
        { 0, 1, 0 },
        { 0, 1, 0 }
    };

    private static readonly int[,] Eight =
    {
        { 1, 1, 1 },
        { 1, 0, 1 },
        { 0, 1, 0 },
        { 1, 0, 1 },
        { 1, 1, 1 }
    };

    private static readonly int[,] Nine = 
    {
        { 1, 1, 1 },
        { 1, 0, 1 },
        { 0, 1, 1 },
        { 0, 0, 1 },
        { 1, 1, 1 }
    };

    public static readonly int[][,] Patterns = 
    {
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine
    };
}

class Program
{
    public static int sum = 0;
    public static int n = int.Parse(Console.ReadLine());
    public static int[][] matrix = new int[n][]
        .Select(x => x = Console.ReadLine().Split().Select(int.Parse).ToArray())
        .ToArray();

    static void Main()
    {
        GetSum();
        PrintSum();
    }

    private static void GetSum()
    {
        for (int row = 0; row < n - Digits.ROW_LEN + 1; row++)
        {
            for (int col = 0; col < n - Digits.COL_LEN + 1; col++)
            {
                int num = matrix[row][col];
                if (IsThereDigit(num, row, col)) { sum += num; }

                if (num != 1)
                    if (matrix[row][col + 2] == 1)
                        if (IsThereDigit(1, row, col)) { sum += 1; }
                if (num != 2)
                    if (matrix[row][col + 1] == 2)
                        if (IsThereDigit(2, row, col)) { sum += 2; }
            }
        }
    }

    private static bool IsThereDigit(int num, int row, int col)
    {
        if (num == 0) { return true; }

        int[,] matrixDigit = Digits.Patterns[num - 1];

        for (int digitRow = 0; digitRow < Digits.ROW_LEN; digitRow++)
        {
            for (int digitCol = 0; digitCol < Digits.COL_LEN; digitCol++)
            {
                int digitInPattern = matrixDigit[digitRow, digitCol];
                int digitInMatrix = matrix[row + digitRow][col + digitCol];

                if (digitInPattern == 1)
                    if (digitInMatrix != num)
                        return false;
            }
        }

        return true;
    }

    private static void PrintSum()
    {
        Console.WriteLine(sum);
    }
}
