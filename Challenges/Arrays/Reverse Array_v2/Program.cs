using System;
using System.Text;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();

        int strLen = str.Length - 1;
        StringBuilder res = new StringBuilder(strLen * 10);
        StringBuilder num = new StringBuilder(10);

        for (int i = strLen; i >= 0; i--)
        {
            if (str[i] != ' ')
            {
                num.Append(str[i]);
            }
            else
            {
                for (int j = num.Length - 1; j >= 0; j--)
                {
                    res.Append(num[j]);
                }
                res.Append(", ");
                num.Clear();
            }
        }

        for (int j = num.Length - 1; j >= 0; j--)
        {
            res.Append(num[j]);
        }

        Console.WriteLine(res);
    }
}
