using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long sum = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = row; col < n; col++)
            {
                sum += (long)Math.Pow(2, row + col);
            }
        }

        Console.WriteLine(sum);
    }
}
