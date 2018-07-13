using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long num01 = long.Parse(Console.ReadLine());
        long num02 = long.Parse(Console.ReadLine());
        long num03 = long.Parse(Console.ReadLine());

        List<long> tribonacci = new List<long> { num01, num02, num03 };

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n + 1) / 2.0 * n - 3; i++)
        {
            long newNum = tribonacci.Skip(i).Take(3).Sum();
            tribonacci.Add(newNum);
        }

        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(tribonacci[counter] + " ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}
