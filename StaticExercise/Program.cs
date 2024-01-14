using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System;


namespace StaticExercise
{
    public class Program
    {
        static void Main()
        {
            // Test Fahrenheit to Celsius conversion
            double fahrenheitTemperature = 68;
            double celsiusResult = TempConverter.FahrenheitToCelsius(fahrenheitTemperature);
            Console.WriteLine($"{fahrenheitTemperature} Fahrenheit is {celsiusResult} Celsius");

            // Test Celsius to Fahrenheit conversion
            double celsiusTemperature = 20;
            double fahrenheitResult = TempConverter.CelsiusToFahrenheit(celsiusTemperature);
            Console.WriteLine($"{celsiusTemperature} Celsius is {fahrenheitResult} Fahrenheit");
        }
    }
}