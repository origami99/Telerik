using System;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int r = int.Parse(size[0]);
        int c = int.Parse(size[1]);

        long sum = 0;
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                if (!(row % 2 == 0 ^ col % 2 == 0))
                {
                    sum += 1 + row * 3 + col * 3;

                    if (row != 0 && row != r - 1 && col != 0 && col != c - 1)
                        sum += 1 + row * 3 + col * 3;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
