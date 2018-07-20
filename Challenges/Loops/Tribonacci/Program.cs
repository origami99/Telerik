using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        BigInteger num01 = BigInteger.Parse(Console.ReadLine());
        BigInteger num02 = BigInteger.Parse(Console.ReadLine());
        BigInteger num03 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        List<BigInteger> tribonacci = new List<BigInteger> { num01, num02, num03 };

        for (int i = 0; i < n - 3; i++)
        {
            BigInteger newNum = tribonacci.Aggregate((a, b) => BigInteger.Add(a, b));
            tribonacci.Add(newNum);
            tribonacci = tribonacci.Skip(1).Take(3).ToList();
        }

        Console.WriteLine(tribonacci.Last());
    }
}
