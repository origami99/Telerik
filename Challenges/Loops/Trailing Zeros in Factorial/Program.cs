using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int zeroes = 0;
        for (int i = 1; ; i++)
        {
            int addZeroes = n / (int)Math.Pow(5, i);
            zeroes += addZeroes;

            if (addZeroes == 0) break;
        }

        Console.WriteLine(zeroes);
    }
}
