using System;

namespace ConverterLib.LengthConvert
{
    public class YardsToMeters : ILengthConverter
    {
        public decimal getLength(decimal length)
        {
            // Meters = Yards * 0.9144000292608
            return length * 0.9144000292608m;
        }
    }
}