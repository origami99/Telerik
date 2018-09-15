using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstPolynom = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondPolynom = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            Console.Write(firstPolynom[i] + secondPolynom[i]);

            if (i != n - 1)
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();
    }
}