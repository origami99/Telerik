using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        KeyValuePair<int, int> result = list.OrderBy(x => x)
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, y => y.Count())
            .OrderByDescending(x => x.Value)
            .First();

        Console.WriteLine($"{result.Key} ({result.Value} times)");
    }
}
