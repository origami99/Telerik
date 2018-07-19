using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Console.WriteLine(GetMaxOccurs(arr));
    }

    private static int GetMaxOccurs(string[] arr)
    {
        if (arr.Length == 0) { return 0; }

        return arr.Select((num, index) => new { Value = num, Index = index })
            .OrderBy(x => x.Value)
            .Select((n, i) => new { n.Value, Diff = i - n.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .Select(g => g.Count())
            .Max();
    }
}
