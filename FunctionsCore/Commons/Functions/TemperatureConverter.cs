using FunctionsCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCore.Commons.Functions
{
    public static class TemperatureConverter
    {
        private static readonly Dictionary<TemperatureUnit, string> Units = new Dictionary<TemperatureUnit, string>
        {
            { TemperatureUnit.Celsius, "C" },
            { TemperatureUnit.Kelvin, "K" },
            { TemperatureUnit.Fahrenheit, "F" },
        };

        public static string GetUnit(TemperatureUnit unit)
        {
            return Units[unit];
        }

        public static double Convert(double value, TemperatureUnit from, TemperatureUnit to)
        {
            double celsiusValue;

            // Convert the input value to Celsius
            switch (from)
            {
                case TemperatureUnit.Celsius:
                    celsiusValue = value;
                    break;
                case TemperatureUnit.Kelvin:
                    celsiusValue = value - 273.15;
                    break;
                case TemperatureUnit.Fahrenheit:
                    celsiusValue = (value - 32) * 5 / 9;
                    break;
                default:
                    throw new ArgumentException("Invalid from measurement");
            }

            // Convert the Celsius value to the target measurement
            switch (to)
            {
                case TemperatureUnit.Celsius:
                    return celsiusValue;
                case TemperatureUnit.Kelvin:
                    return celsiusValue + 273.15;
                case TemperatureUnit.Fahrenheit:
                    return celsiusValue * 9 / 5 + 32;
                default:
                    throw new ArgumentException("Invalid to measurement");
            }
        }
    }
}
