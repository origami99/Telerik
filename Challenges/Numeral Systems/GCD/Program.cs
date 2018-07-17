using System;

class GCD
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        while (b != 0)
        {
            int previousB = b;
            b = a % b;
            a = previousB;
        }

        Console.WriteLine(a);
    }
}