using System;

namespace ConverterLib.TemperatureConvert
{
    public class CelsiusToFahrenheit : ITemperatureConverter
    {
        public decimal getTemperature(decimal temp)
        {
            // T(F) = [T(C) * (9/5)] + 32
            return temp * (9m/5m) + 32;
        }
    }
}