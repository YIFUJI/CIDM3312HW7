using System;

namespace ConverterLib.TemperatureConvert
{
    public class CelsiusToKelvin : ITemperatureConverter
    {
        public decimal getTemperature(decimal temp)
        {
            // T(K) = T(C) + 273.15
            return temp + 273.15m;
        }
    }
}