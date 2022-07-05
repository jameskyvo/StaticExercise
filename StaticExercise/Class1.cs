using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempinFahrenheit)
        {
            return (tempinFahrenheit - 32) * .5556;
        }

        public static double CelsiusToFahrenheit(double tempinCelsius)
        {
            return tempinCelsius * 1.8 + 32;
        }


    }
}
