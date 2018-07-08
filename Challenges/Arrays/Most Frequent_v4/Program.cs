using System;

class Program
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        short[] occurs = new short[10001];
        for (int i = 0; i < n; i++)
        {
            short num = short.Parse(Console.ReadLine());
            occurs[num]++;
        }

        short bestOccurs = 0;
        short bestNum = 0;

        for (short i = 0; i < occurs.Length; i++)
        {
            if (occurs[i] > bestOccurs)
            {
                bestOccurs = occurs[i];
                bestNum = i;
            }
        }

        Console.WriteLine($"{bestNum} ({bestOccurs} times)");
    }
}
