using System;

namespace ConverterLib.MassConvert
{
    public class PoundsToKilos : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Kilograms = Pounds / 2.205
            return mass / 2.205m;
        }
    }
}