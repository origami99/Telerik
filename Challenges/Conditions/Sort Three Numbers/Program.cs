using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a < b)
            Swap(ref a, ref b);
        if (b < c)
            Swap(ref b, ref c);
        if (a < b)
            Swap(ref a, ref b);

        Console.WriteLine($"{a} {b} {c}");
    }

    private static void Swap(ref int x, ref int y)
    {
        x = x ^ y;
        y = x ^ y;
        x = x ^ y;
    }
}
