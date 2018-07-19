using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static object Hashset { get; private set; }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n].Select(x => x = int.Parse(Console.ReadLine())).ToArray();

        HashSet<int> maxes = new HashSet<int>() { 0 };

        int counter = 1;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i + 1] > arr[i])
                maxes.Add(++counter);
            else
                counter = 1;
        }

        Console.WriteLine(maxes.Max());
    }
}
