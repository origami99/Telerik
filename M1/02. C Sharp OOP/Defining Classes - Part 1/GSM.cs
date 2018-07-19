using System;

class GSM
{
    private string model = null;
    private string manufacturer = null;
    private decimal price;
    private string owner = null;

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
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException();
            if (value == string.Empty)
                throw new ArgumentException($"Manufacturer can not be empty string");

            this.manufacturer = value;
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Price can't be negative");

            this.price = value;
        }
    }
    public string Owner
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException();
            if (value == string.Empty)
                throw new ArgumentException($"Owner can not be empty string");

            this.owner = value;
        }
    }
    public Battery Battery { get; set; }
    public Display Display { get; set; }

    public GSM(string model, string manufacturer)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
    }

    public GSM(string model, string manufacturer, decimal price, string owner)
        : this(model, manufacturer)
    {
        this.Price = price;
        this.Owner = owner;
    }

    public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        : this(model, manufacturer, price, owner)
    {
        this.Battery = battery;
        this.Display = display;
    }

    public override string ToString()
    {
        return $"{manufacturer}; {model}; {price}; {owner}; Battery:{Battery.Model}, {Battery.HoursIdle}, {Battery.HoursTalk}; Display:{Display.Size}, {Display.NumberOfColors}";
    }
}
