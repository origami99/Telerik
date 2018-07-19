using System;

class Startup
{
    static void Main()
    {
        GSM gsm = new GSM("J7", "Samsung");

        Console.WriteLine(gsm.Price);
    }
}
