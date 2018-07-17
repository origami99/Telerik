using System;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CalcFactorial(n));
    }

    private static BigInteger CalcFactorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}