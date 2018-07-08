using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (!occurrences.ContainsKey(num))
            {
                occurrences.Add(num, 0);
            }
            occurrences[num]++;
        }

        KeyValuePair<int, int> result = occurrences.OrderByDescending(x => x.Value).First();

        Console.WriteLine($"{result.Key} ({result.Value} times)");
    }
}
