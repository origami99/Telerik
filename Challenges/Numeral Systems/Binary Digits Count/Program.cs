using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        char b = char.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long num = long.Parse(Console.ReadLine());
            string bin = Convert.ToString(num, 2);
            Console.WriteLine(bin.Count(x => x == b));
        }
    }
}
