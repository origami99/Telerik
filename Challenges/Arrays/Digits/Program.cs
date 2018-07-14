using System;
using System.Linq;

public class Digits
{
    public const int ROW_LEN = 5;
    public const int COL_LEN = 3;

    private static readonly int[][] Zero = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    private static readonly int[][] One = new int[][]
    {
        new int[] { 0, 0, 1 },
        new int[] { 0, 1, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 0, 0, 1 }
    };

    private static readonly int[][] Two = new int[][]
    {
        new int[] { 0, 1, 0 },
        new int[] { 1, 0, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 0, 1, 0 },
        new int[] { 1, 1, 1 }
    };

    private static readonly int[][] Three = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 0, 1, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    private static readonly int[][] Four = new int[][]
    {
        new int[] { 1, 0, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 1, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 0, 0, 1 }
    };

    private static readonly int[][] Five = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 0 },
        new int[] { 1, 1, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    private static readonly int[][] Six = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 0 },
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    private static readonly int[][] Seven = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 0, 1, 0 },
        new int[] { 0, 1, 0 },
        new int[] { 0, 1, 0 }
    };

    private static readonly int[][] Eight = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 0, 1, 0 },
        new int[] { 1, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    private static readonly int[][] Nine = new int[][]
    {
        new int[] { 1, 1, 1 },
        new int[] { 1, 0, 1 },
        new int[] { 0, 1, 1 },
        new int[] { 0, 0, 1 },
        new int[] { 1, 1, 1 }
    };

    public static readonly int[][][] Patterns = new int[][][]
    {
        Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine
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

                /* 
                 * The 1 & 2 patterns are kinda special wherefore I check them 
                 * explicitly under certain conditions, and it's rather little hack 
                 * for the sake of I'll refactor the algorithm in future 
                 */
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
        int[][] matrixDigit = Digits.Patterns[num];

        for (int digitRow = 0; digitRow < Digits.ROW_LEN; digitRow++)
        {
            for (int digitCol = 0; digitCol < Digits.COL_LEN; digitCol++)
            {
                int digitInPattern = matrixDigit[digitRow][digitCol];
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
