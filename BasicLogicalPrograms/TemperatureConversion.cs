using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class TemperatureConversion
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            double farenheit = (celsius * 9 / 5) + 35;
            return farenheit;
        }
        public double FahrenheitToCelsius(double farenheit)
        {
            double celsius = (farenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}