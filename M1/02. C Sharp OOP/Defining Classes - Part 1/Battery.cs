using System;

enum BatteryType
{
    Li_Ion = 0,
    NiMH = 1,
    NiCd = 2
}

internal class Battery
{
    private string model;
    private double hoursIdle;
    private double hoursTalk;
    private BatteryType type;

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException();
            if (value == string.Empty)
                throw new ArgumentException($"Model can not be empty string");

            this.model = value;
        }
    }
    public double HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Hours must be greater than zero");

            this.hoursIdle = value;
        }
    }
    public double HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Hours must be greater than zero");

            this.hoursTalk = value;
        }
    }
    public BatteryType Type { get; set; } // TODO

    public Battery(string model)
    {
        this.Model = model;
    }

    public Battery(string model, double hoursIdle, double hoursTalk)
        : this(model)
    {
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        : this(model, hoursIdle, hoursTalk)
    {
        this.Type = type;
    }
}
