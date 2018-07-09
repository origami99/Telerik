using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var arr = Enumerable.Range(0, n).Select(x => x * 5);
        Console.WriteLine(string.Join("\n", arr));
    }
}
