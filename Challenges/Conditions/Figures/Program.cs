using System;
using System.Linq;

class Program
{
    private const int TRIANGLE_SIDES_COUNT = 3;
    private const int RECTANGLE_SIDES_COUNT = 4;

    static void Main()
    {
        int[] sides = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] triangleSides = new int[TRIANGLE_SIDES_COUNT];
        for (int i = 0; i < TRIANGLE_SIDES_COUNT; i++)
        {
            triangleSides[i] = sides[i];
        }

        int[] rectangleSides = new int[RECTANGLE_SIDES_COUNT];
        for (int i = 0; i < RECTANGLE_SIDES_COUNT / 2; i++)
        {
            int input = sides[TRIANGLE_SIDES_COUNT + i];

            rectangleSides[i] = input;
            rectangleSides[i + 2] = input;
        }

        int sumCircumference = triangleSides.Sum() + rectangleSides.Sum();
        int minCircumference = int.MaxValue;

        for (int tr = 0; tr < TRIANGLE_SIDES_COUNT; tr++)
        {
            for (int rec = 0; rec < RECTANGLE_SIDES_COUNT; rec++)
            {
                int trSide = triangleSides[tr];
                int recSide = rectangleSides[rec];

                int smallerSide = Math.Min(trSide, recSide);

                int currCircumference = sumCircumference - smallerSide * 2;

                if (currCircumference < minCircumference)
                {
                    minCircumference = currCircumference;
                }
            }
        }

        Console.WriteLine(minCircumference);
    }
}