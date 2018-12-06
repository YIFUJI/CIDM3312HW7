using System;

namespace ConverterLib.MassConvert
{
    public class KilosToOunces : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Ounces = Kilograms * 35.274
            return mass * 35.274m;
        }
    }
}