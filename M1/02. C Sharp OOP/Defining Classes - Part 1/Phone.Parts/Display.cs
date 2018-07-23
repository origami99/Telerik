namespace Phone.Parts
{
    using System;

    internal class Display
    {
        private double size;
        private int numberOfColors;

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Size must be positive number");

                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Number of colors must be positive number");

                this.numberOfColors = value;
            }
        }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int numbersofColors) : this(size)
        {
            this.NumberOfColors = numbersofColors;
        }
    }
}