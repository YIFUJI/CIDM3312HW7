using System;

namespace ConverterLib.MassConvert
{
    public class OuncesToKilos : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Kilograms = Ounces / 35.274
            return mass / 35.274m;
        }
    }
}