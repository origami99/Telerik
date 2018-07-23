using System;

class Call
{
    public string PhoneNumber { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }

    public Call(string phoneNumber, DateTime date, TimeSpan duration)
    {
        this.PhoneNumber = PhoneNumber;
        this.Date = Date;
        this.Duration = Duration;
    }
}
