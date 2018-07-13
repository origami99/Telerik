using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = a.Length;
        bool[,] m = new bool[n + 1, k + 1];

        for (int i = 0; i <= k; i++)
        {
            m[0, i] = false;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int s = 0; s <= k; s++)
            {
                if (s - a[i - 1] >= 0)
                {
                    m[i, s] = (m[i - 1, s] || a[i - 1] == s || m[i - 1, s - a[i - 1]]);
                }
                else
                {
                    m[i, s] = (m[i - 1, s] || a[i - 1] == s);
                }
            }
        }

        Console.WriteLine(m[n, k] ? "yes" : "no");
    }
}