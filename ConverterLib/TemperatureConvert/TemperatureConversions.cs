using System;

namespace ConverterLib.TemperatureConvert
{
    public interface ITemperatureConverter
    {
        // Set the public declaration of a variable
        decimal getTemperature(decimal temp);
    }
}
