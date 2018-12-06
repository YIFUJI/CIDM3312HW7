using System;

namespace ConverterLib.LengthConvert
{
    public class MetersToYards : ILengthConverter
    {
        public decimal getLength(decimal length)
        {
            // Yards = Meters * 1.094
            return length * 1.094m;
        }
    }
}