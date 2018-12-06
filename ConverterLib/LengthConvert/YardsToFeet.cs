using System;

namespace ConverterLib.LengthConvert
{
    public class YardsToFeet : ILengthConverter
    {
        public decimal getLength(decimal length)
        {
            // Feet = Yards * 3
            return length * 3m;
        }
    }
}