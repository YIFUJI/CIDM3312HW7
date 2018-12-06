using System;

namespace ConverterLib.MassConvert
{
    public class GramsToPounds : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Pounds = Grams * 453.592
            return mass * 453.592m;
        }
    }
}