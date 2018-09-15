using System;
using System.Linq;

class Program
{
    public static char[] road = Console.ReadLine().ToArray();
    public static int[] moves = Console.ReadLine().Split().Select(int.Parse).ToArray();

    public static int soulsCount = 0;
    public static int foodsCount = 0;
    public static int deadsCount = 0;

    public static bool isKittyAlive = true;
    public static int kittyPos = 0;
    public static int jumps = 0;

    static void Main()
    {
        while (true)
        {
            Collect();
            if (!isKittyAlive) return;
            if (jumps == moves.Length) break;
            AssignKittyPos();
            jumps++;
        }

        PrintResults();
    }

    private static void AssignKittyPos()
    {
        int move = moves[jumps];

        if (move > 0)
        {
            kittyPos = (kittyPos + move) % road.Length;
        }
        if (move < 0)
        {
            kittyPos = (kittyPos + move) % road.Length;

            if (kittyPos < 0)
            {
                kittyPos += road.Length;
            }
        }
    }

    private static void Collect()
    {
        char item = road[kittyPos];

        switch (item)
        {
            case '@':
                soulsCount++;
                road[kittyPos] = ' ';
                break;
            case '*':
                foodsCount++;
                road[kittyPos] = ' ';
                break;
            case 'x':
                deadsCount++;
                switch (kittyPos % 2)
                {
                    case 0:
                        road[kittyPos] = '@';
                        soulsCount--;
                        break;
                    case 1:
                        road[kittyPos] = '*';
                        foodsCount--;
                        break;
                }

                if (soulsCount < 0 || foodsCount < 0)
                {
                    isKittyAlive = false;
                    PrintDead();
                }
                break;
        }
    }

    private static void PrintDead()
    {
        Console.WriteLine("You are deadlocked, you greedy kitty!");
        Console.WriteLine($"Jumps before deadlock: {jumps}");
    }

    private static void PrintResults()
    {
        Console.WriteLine($"Coder souls collected: {soulsCount}");
        Console.WriteLine($"Food collected: {foodsCount}");
        Console.WriteLine($"Deadlocks: {deadsCount}");
    }
}
