using System;

namespace ConverterLib.LengthConvert
{
    public class FeetToMeters : ILengthConverter
    {
        public decimal getLength(decimal length)
        {
            // Meters = Feet * 3.28084 
           return length * 3.28084m;
        }
    }
}