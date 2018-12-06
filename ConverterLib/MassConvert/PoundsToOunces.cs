using System;

namespace ConverterLib.MassConvert
{
    public class PoundsToOunces : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            /// Ounces = Pounds * 16
            return mass * 16m;
        }
    }
}