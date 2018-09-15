using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int loniStart = input[0] * 60 + input[1];
        int loniEnd = input[2] * 60 + input[3];

        int moniStart = input[4] * 60 + input[5];
        int moniEnd = input[6] * 60 + input[7];

        if (loniStart <= moniStart && loniEnd >= moniStart)
        {
            int interStart = moniStart;
            int interEnd = Math.Min(loniEnd, moniEnd);

            Console.WriteLine($"{interStart / 60} {interStart % 60} {interEnd / 60} {interEnd % 60}");
            return;
        }
        if (moniStart <= loniStart && moniEnd >= loniStart)
        {
            int interStart = loniStart;
            int interEnd = Math.Min(loniEnd, moniEnd);

            Console.WriteLine($"{interStart / 60} {interStart % 60} {interEnd / 60} {interEnd % 60}");
            return;
        }

        Console.WriteLine("No");
    }
}
