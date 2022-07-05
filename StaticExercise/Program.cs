using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsiusOutput = TempConverter.FahrenheitToCelsius(55.3);
            var fahrenheitOutput = TempConverter.CelsiusToFahrenheit(55.3);
            Console.WriteLine(celsiusOutput);
            Console.WriteLine(fahrenheitOutput);
        }
    }
}
