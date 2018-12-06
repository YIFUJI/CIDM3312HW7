using System;

namespace ConverterLib.MassConvert
{
    public class KilosToGrams : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Grams = Kilograms * 1000
            return mass * 1000m;
        }
    }
}