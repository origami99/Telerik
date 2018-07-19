using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string symb = Console.ReadLine();

        if (n == 0) return;
        if (n == 1)
        {
            Console.WriteLine(1);
            return;
        }

        int[,] matrix = new int[n, n];

        switch (symb)
        {
            case "a":
                AFill(ref matrix);
                break;
            case "b":
                BFill(ref matrix);
                break;
            case "c":
                CFill(ref matrix);
                break;
            case "d":
                DFill(ref matrix);
                break;
        }

        PrintMatrix(matrix);
    }

    private static void AFill(ref int[,] matrix)
    {
        int n = matrix.GetLength(0);

        int counter = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = ++counter;
            }
        }
    }

    private static void BFill(ref int[,] matrix)
    {
        int n = matrix.GetLength(0);

        int counter = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row % 2 == 0)
                {
                    matrix[col, row] = ++counter;
                }
                else
                {
                    matrix[n - col - 1, row] = ++counter;
                }
            }
        }
    }

    private static void CFill(ref int[,] matrix)
    {
        int n = matrix.GetLength(0);

        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                matrix[n - i + j - 1, j] = ++counter;
            }
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                matrix[j, i + j + 1] = ++counter;
            }
        }
    }

    private static void DFill(ref int[,] matrix)
    {
        int n = matrix.GetLength(0);

        string direction = "down";
        int counter = 0;
        int boundTrimmer = 0;
        int row = 0;
        int col = 0;

        matrix[0, 0] = ++counter;
        while (boundTrimmer != n / 2 + 1) 
        {
            if (direction == "down")
            {
                if (row + 1 < n - boundTrimmer)
                {
                    row++;
                    matrix[row, col] = ++counter; 
                }
                else
                {
                    direction = "right";
                }
            }
            else if (direction == "up")
            {
                if (row - 1 >= boundTrimmer)
                {
                    row--;
                    matrix[row, col] = ++counter;
                }
                else
                {
                    direction = "left";
                    boundTrimmer++;
                }
            }
            else if (direction == "right")
            {
                if (col + 1 < n - boundTrimmer)
                {
                    col++;
                    matrix[row, col] = ++counter;
                }
                else
                {
                    direction = "up";
                }
            }
            else if (direction == "left")
            {
                if (col - 1 >= boundTrimmer)
                {
                    col--;
                    matrix[row, col] = ++counter;
                }
                else
                {
                    direction = "down";
                }
            }
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
