using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string url = Console.ReadLine();

        Regex regex = new Regex(@"(?<protocol>.+)\:\/\/(?<server>\w+\.\w+)(?<resource>.+)*");
        Match urlElements = regex.Match(url);

        Console.WriteLine("[protocol] = " + urlElements.Groups["protocol"].Value);
        Console.WriteLine("[server] = " + urlElements.Groups["server"].Value);
        Console.WriteLine("[resource] = " + urlElements.Groups["resource"].Value);
    }
}
