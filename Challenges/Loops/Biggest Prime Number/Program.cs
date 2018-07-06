using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
                return;
            }
        }
    }

    private static bool IsPrime(int n)
    {
        for (int j = 2; j <= Math.Sqrt(n); j++)
        {
            if (n % j == 0)
            {
                return false;
            }
        }

        return true;
    }
}
