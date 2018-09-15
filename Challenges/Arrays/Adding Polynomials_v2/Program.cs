using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstPolynom = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondPolynom = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(string.Join(" ", firstPolynom.Select((x, y) => x = x + secondPolynom[y])));
    }
}
