using System;

namespace ConverterLib.MassConvert
{
    public class KilosToPounds : IMassConverter
    {
        public decimal getMass(decimal mass)
        {
            // Pounds = Kilograms * 2.205
            return mass * 2.205m;
        }
    }
}