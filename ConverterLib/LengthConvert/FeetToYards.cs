using System;

namespace ConverterLib.LengthConvert
{
    public class FeetToYards : ILengthConverter
    {
        public decimal getLength(decimal length)
        {
            // Yards = Feet * (1/3)
            return length * (1m/3m);
        }
    }
}