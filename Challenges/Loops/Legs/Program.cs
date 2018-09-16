using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sevensBound = (int)Math.Ceiling(n / 7.0);
        int fivesBound = (int)Math.Ceiling(n / 5.0);
        int twosBound = (int)Math.Ceiling(n / 2.0);

        int combinations = 0;
        for (int i = 0; i <= sevensBound; i++)
        {
            for (int j = 0; j <= fivesBound; j++)
            {
                for (int k = 0; k <= twosBound; k++)
                {
                    if ((i * 7) + (j * 5) + (k * 2) == n)
                    {
                        combinations++;
                    }
                }
            }
        }

        Console.WriteLine(combinations);
    }
}
