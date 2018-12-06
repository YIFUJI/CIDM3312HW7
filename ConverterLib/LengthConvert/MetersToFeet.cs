using System;

namespace ConverterLib.LengthConvert
{
    public class MetersToFeet : ILengthConverter
    {
        public decimal getLength(decimal length)
        {
            // Feet = Meters / 0.3048 
            return length / 0.3048m;
        }
    }
}