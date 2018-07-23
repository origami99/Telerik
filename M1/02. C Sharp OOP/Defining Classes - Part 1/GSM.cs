namespace Phone
{
    using System;
    using Phone.Parts;
    using System.Collections.Generic;

    class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private decimal price;
        private string owner = null;
        private List<Call> callHistory = new List<Call>();

        private static readonly GSM iPhone4S = new GSM("iPhone 4s", "Apple", 200, "Kifla",
            new Battery("Dzhan-Min", 40, 8, BatteryType.Li_Ion),
            new Display(3, 16000000));

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
        public static GSM IPhone4S
        {
            get
            {
                return IPhone4S;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(callHistory);
            }
            set
            {
                callHistory = value;
            }
        }


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

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void AddCall(string phoneNumber, DateTime date, TimeSpan duration)
        {
            Call call = new Call(phoneNumber, date, duration);
            CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public override string ToString()
        {
            return $"Phone: {manufacturer} {model}\nPrice: {price}\nOwner: {owner}"; //Battery:{Battery.Model}, {Battery.HoursIdle}, {Battery.HoursTalk}; Display:{Display.Size}, {Display.NumberOfColors}.";
        }
    }
}