using System;

namespace ConverterLib.MassConvert
{
    public class PoundsToGrams : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Grams = Pounds / 453.592
            return mass / 453.592m;
        }
    }
}