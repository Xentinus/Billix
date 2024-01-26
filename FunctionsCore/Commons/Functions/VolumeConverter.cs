using FunctionsCore.Enums.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCore.Commons.Functions
{
    public static class VolumeConverter
    {
        private static readonly Dictionary<VolumeUnit, string> Units = new Dictionary<VolumeUnit, string>
        {
            { VolumeUnit.Milliliter, "ml" },
            { VolumeUnit.FluidOunce, "fl dr" },
            { VolumeUnit.Centiliter, "cl" },
            { VolumeUnit.Deciliter, "dl" },
            { VolumeUnit.Cup, "cp" },
            { VolumeUnit.Pint, "pt" },
            { VolumeUnit.Quart, "qt" },
            { VolumeUnit.Liter, "l" },
            { VolumeUnit.Gallon, "gal" },
            { VolumeUnit.Hektoliter, "hl" },
            { VolumeUnit.Cubicyard, "yd3" },
            { VolumeUnit.Cubicmeter, "m3" },
        };

        public static string GetUnit(VolumeUnit unit)
        {
            return Units[unit];
        }

        public static double Convert(double value, VolumeUnit from, VolumeUnit to)
        {
            double literValue;

            // Convert the input value to liters
            switch (from)
            {
                case VolumeUnit.Milliliter:
                    literValue = value * 0.001;
                    break;
                case VolumeUnit.FluidOunce:
                    literValue = value * 0.0295735;
                    break;
                case VolumeUnit.Centiliter:
                    literValue = value * 0.01;
                    break;
                case VolumeUnit.Deciliter:
                    literValue = value * 0.1;
                    break;
                case VolumeUnit.Cup:
                    literValue = value * 0.236588;
                    break;
                case VolumeUnit.Pint:
                    literValue = value * 0.473176;
                    break;
                case VolumeUnit.Quart:
                    literValue = value * 0.946353;
                    break;
                case VolumeUnit.Liter:
                    literValue = value;
                    break;
                case VolumeUnit.Hektoliter:
                    literValue = value * 100;
                    break;
                case VolumeUnit.Cubicyard:
                    literValue = value * 764.555;
                    break;
                case VolumeUnit.Cubicmeter:
                    literValue = value * 1000;
                    break;
                default:
                    throw new ArgumentException("Invalid from measurement");
            }

            // Convert the liter value to the target measurement
            switch (to)
            {
                case VolumeUnit.Milliliter:
                    return literValue / 0.001;
                case VolumeUnit.FluidOunce:
                    return literValue / 0.0295735;
                case VolumeUnit.Centiliter:
                    return literValue / 0.01;
                case VolumeUnit.Deciliter:
                    return literValue / 0.1;
                case VolumeUnit.Cup:
                    return literValue / 0.236588;
                case VolumeUnit.Pint:
                    return literValue / 0.473176;
                case VolumeUnit.Quart:
                    return literValue / 0.946353;
                case VolumeUnit.Liter:
                    return literValue;
                case VolumeUnit.Hektoliter:
                    return literValue / 100;
                case VolumeUnit.Cubicyard:
                    return literValue / 764.555;
                case VolumeUnit.Cubicmeter:
                    return literValue / 1000;
                default:
                    throw new ArgumentException("Invalid to measurement");
            }
        }
    }
}
