using System;

namespace ConverterLib.TemperatureConvert
{
    public class FahrenheitToKelvin : ITemperatureConverter
    {
        public decimal getTemperature(decimal temp)
        {
            // T(K) = [T(F) + 459.67] * (5/9)
            return (temp + 459.67m) * (5m/9m);
        }
    }
}