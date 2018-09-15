using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] cats = new int[10];

        for (int i = 0; i < n; i++)
            cats[int.Parse(Console.ReadLine()) - 1]++;

        int mostVotes = -1;
        int winner = 0;
        for (int i = 0; i < 10; i++)
        {
            if (cats[i] > mostVotes)
            {
                mostVotes = cats[i];
                winner = i;
            }
        }

        Console.WriteLine(winner + 1);
    }
}
