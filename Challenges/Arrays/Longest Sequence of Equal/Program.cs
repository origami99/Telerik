using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxOccur = 1;
        int occur = 0;
        int prevNum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == prevNum) occur++;
            else occur = 1;

            if (occur >= maxOccur)
            {
                maxOccur = occur;
            }

            prevNum = num;
        }

        Console.WriteLine(maxOccur);
    }
}
