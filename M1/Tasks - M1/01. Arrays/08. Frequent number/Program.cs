using System;

class Program
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        short bestOccurs = 0;
        short bestNum = 0;

        short[] occurs = new short[10001];
        for (short i = 0; i < n; i++)
        {
            short num = short.Parse(Console.ReadLine());
            occurs[num]++;

            if (occurs[num] > bestOccurs)
            {
                bestOccurs = occurs[num];
                bestNum = num;
            }
        }

        Console.WriteLine($"{bestNum} ({bestOccurs} times)");
    }
}
