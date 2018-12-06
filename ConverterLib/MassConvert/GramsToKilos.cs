using System;

namespace ConverterLib.MassConvert
{
    public class GramsToKilos: IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Kilograms = Grams / 1000
            return mass / 1000m;
        }
    }
}