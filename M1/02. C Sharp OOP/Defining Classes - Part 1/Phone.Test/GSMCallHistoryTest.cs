using System;
using System.Linq;

namespace Phone.Test
{
    static class GSMCallHistoryTest
    {
        public static void Start()
        {
            // TODO 

            GSM phone = new GSM("Pixel", "Google");

            phone.AddCall("+359 123-456", new DateTime(2018, 7, 22), new TimeSpan(0, 1, 15));
            phone.AddCall("089123456", new DateTime(2018, 6, 17), new TimeSpan(0, 3, 20));
            phone.AddCall("+12 3123 121", new DateTime(2017, 1, 22), new TimeSpan(1, 5, 0));

            foreach (Call call in phone.CallHistory)
            {
                Console.WriteLine($"Phone: {call.PhoneNumber}, Call Date: {call.Date}, Duration: {call.Duration}");
            }

            PrintBill(phone);

            // Remove longest call from history
            Call longestCall = new Call("", new DateTime(), new TimeSpan(-1));
            foreach (Call call in phone.CallHistory)
            {
                if (call.Duration.Seconds > longestCall.Duration.Seconds)
                {
                    longestCall = call;
                }
            }
            phone.DeleteCall(longestCall);

            PrintBill(phone);
        }

        private static void PrintBill(GSM phone)
        {
            decimal bill = phone.TotalCallsPrice(0.37m);
            Console.WriteLine(bill);
        }
    }
}
