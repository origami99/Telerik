using System;

class Program
{
    static void Main()
    {
        ReadNumber(1, 100);
    }

    private static void ReadNumber(int start, int end)
    {
        int prevNum = 1;
        for (int i = 0; i < 10; i++)
        {
            // without try-catch block the behavior will be the same
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }

            if (num <= prevNum || num >= 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            prevNum = num;
        }
    }
}
