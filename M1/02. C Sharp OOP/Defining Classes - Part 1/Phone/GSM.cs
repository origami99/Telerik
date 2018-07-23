namespace Phone
{
    using System;
    using Phone.Parts;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

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
                return GSM.iPhone4S;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
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
            this.callHistory.Add(call);
        }

        public void AddCall(string phoneNumber, DateTime date, TimeSpan duration)
        {
            Call call = new Call(phoneNumber, date, duration);
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal TotalCallsPrice(decimal pricePerMin)
        {
            double totalMinutes = callHistory.Select(x => x.Duration.TotalMinutes).Sum();

            decimal totalPrice = (decimal)totalMinutes * pricePerMin;

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Phone:");
            str.AppendLine($"   Manufacturer: {manufacturer}");
            str.AppendLine($"   Model: {model}");
            str.AppendLine($"   Owner: {owner}");

            if (Battery != null)
                str.Append(this.Battery.ToString());
            if (Display != null)
                str.Append(this.Display.ToString());

            return str.ToString();
        }
    }
}