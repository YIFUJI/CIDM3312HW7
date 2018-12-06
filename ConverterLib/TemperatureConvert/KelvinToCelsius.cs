using System;

namespace ConverterLib.TemperatureConvert
{
    public class KelvinToCelsius : ITemperatureConverter
    {
        public decimal getTemperature(decimal temp)
        {
            // T(C) = T(K) - 273.15
            return temp - 273.15m;
        }
    }
}