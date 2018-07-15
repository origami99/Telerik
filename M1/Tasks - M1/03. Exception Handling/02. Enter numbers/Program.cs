using System;

class Program
{
    static void Main()
    {
        ReadNumber(1, 100);
    }

    private static void ReadNumber(int start, int end)
    {
        int prevNum = start;
        for (int i = 0; i < 10; i++)
        {
            // without try-catch block the behavior will be the same
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(nameof(num));
            }
            catch (FormatException)
            {
                throw new FormatException(nameof(num));
            }
            catch (OverflowException)
            {
                throw new OverflowException(nameof(num));
            }

            if (num <= prevNum || num >= end)
            {
                throw new ArgumentOutOfRangeException(nameof(num));
            }

            prevNum = num;
        }
    }
}
