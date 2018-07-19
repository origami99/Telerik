using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "yuki@abv.bg? Yes, this is just a string with random email like this steven@yahoo.com, or this marto@me.com. Ooo, by the way this one is not mine - origamista99@gmail.com... definitely";

        Regex regex = new Regex(@"[a-z0-9][-a-z0-9._]+@([-a-z0-9]+\.)+[a-z]+");

        MatchCollection emails = regex.Matches(text);

        foreach (Match email in emails)
            Console.WriteLine(email.Value);
    }
}
