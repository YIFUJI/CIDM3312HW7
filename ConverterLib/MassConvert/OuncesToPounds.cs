using System;

namespace ConverterLib.MassConvert
{
    public class OuncesToPounds : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Pounds = Ounces / 16
            return mass / 16m;
        }
    }
}