using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string num = string.Empty;
        string message;

        while ((message = Console.ReadLine()) != "end")
        {
            if (message.StartsWith("set"))
                num = message.Split().Last();
            else if (message.StartsWith("front-add"))
                num = message.Split().Last() + num;
            else if (message.StartsWith("back-add"))
                num += message.Split().Last();
            else if (message.StartsWith("front-remove") && num != string.Empty)
                num = new string(num.Skip(1).ToArray());
            else if (message.StartsWith("back-remove") && num != string.Empty)
                num = new string(num.SkipLast(1).ToArray());
            else if (message.StartsWith("reverse"))
                num = new string(num.ToArray().Reverse().ToArray());
            else if (message.StartsWith("print"))
                Console.WriteLine(num);
        }
    }
}
