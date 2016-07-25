using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class TemperatureConverter
    {
        public double CelsiusToFahrenheit( string tempCelsius )
        {
            double celsius = Double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fahrenheit = double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
