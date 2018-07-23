namespace Phone.Test
{
    using System;

    public static class GSMTest
    {
        public static void Start()
        {
            GSM[] phones = new GSM[3];

            phones[0] = new GSM("Pixel 2XL", "Google");
            phones[1] = new GSM("J7 Pro 2017", "Samsung");
            phones[2] = new GSM("3310", "Nokia");

            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}