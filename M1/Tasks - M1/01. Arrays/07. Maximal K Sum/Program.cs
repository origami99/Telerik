using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            list.Add(num);
        }

        int maxSum = list.OrderByDescending(x => x).Take(k).Sum();

        Console.WriteLine(maxSum);
    }
}
