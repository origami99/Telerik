using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            if (IsPrimeFast(i))
            {
                Console.WriteLine(i);
                return;
            }
        }
    }

    private static bool IsPrimeFast(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i = i + 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}
