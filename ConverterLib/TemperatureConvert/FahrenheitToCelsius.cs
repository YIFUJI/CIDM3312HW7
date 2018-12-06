using System;

namespace ConverterLib.TemperatureConvert
{
    public class FahrenheitToCelsius : ITemperatureConverter
    {
        public decimal getTemperature(decimal temp)
        {
            // T(C) = [T(F) - 32] * (5/9)
            return (temp - 32m) * (5m/9m);
        }
    }
}