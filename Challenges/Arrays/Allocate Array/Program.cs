using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] result = Enumerable.Range(0, n).Select(x => x * 5).ToArray();

        Console.WriteLine(string.Join("\n", result));
    }
}
