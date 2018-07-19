using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] charArr1 = Console.ReadLine().ToCharArray();
        char[] charArr2 = Console.ReadLine().ToCharArray();

        string equality = GetArrEquality(charArr1, charArr2);

        Console.WriteLine(equality);
    }

    private static string GetArrEquality(char[] charArr1, char[] charArr2)
    {
        int minLen = new[] { charArr1.Length, charArr2.Length }.Min();

        for (int i = 0; i < minLen; i++)
        {
            if (charArr1[i] != charArr2[i])
            {
                if (charArr1[i] > charArr2[i])
                    return ">";
                else
                    return "<";
            }
        }

        return "=";
    }
}
