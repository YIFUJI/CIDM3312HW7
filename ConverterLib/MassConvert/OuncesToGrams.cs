using System;

namespace ConverterLib.MassConvert
{
    public class OuncesToGrams : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Grams = Ounces / 28.3495
            return mass / 28.3495m;
        }
    }
}