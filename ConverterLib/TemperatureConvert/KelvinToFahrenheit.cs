using System;

namespace ConverterLib.TemperatureConvert
{
    public class KelvinToFahrenheit: ITemperatureConverter
    {
        public decimal getTemperature(decimal temp)
        {
            // T(F) = [T(K) * (9/5)] - 459.67
            return (temp * (9m/5m)) - 459.67m;
        }
    }
}