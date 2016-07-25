using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter Celsius to Fahr or Fahr to Celsius");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the cels temp: ");
                        TemperatureConverter converter = new TemperatureConverter();
                        fahrenheit = converter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the fahr temp: ");
                        converter = new TemperatureConverter();
                        celsius = converter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;
                    case "q":
                    case "Q":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
