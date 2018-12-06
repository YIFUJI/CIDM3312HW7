using System;

namespace ConverterLib.MassConvert
{
    public class GramsToOunces: IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Ounces = Grams * 28.3495
            return mass * 28.3495m;
        }
    }
}