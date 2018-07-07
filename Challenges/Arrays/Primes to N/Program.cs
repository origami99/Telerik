using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> primes = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", primes));
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
