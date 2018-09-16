using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = -n + 1; i < n; i++)
        {
            Console.WriteLine(string.Join(" ",
                Enumerable.Range(1, n - Math.Abs(i))));
        }
    }
}
