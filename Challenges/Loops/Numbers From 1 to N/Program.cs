using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = Enumerable.Range(1, n).ToArray();

        Console.WriteLine(string.Join(" ", nums));
    }
}
