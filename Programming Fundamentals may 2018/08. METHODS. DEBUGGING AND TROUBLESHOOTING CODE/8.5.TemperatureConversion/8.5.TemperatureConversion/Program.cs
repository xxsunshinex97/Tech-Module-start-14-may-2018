using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrnheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelcius(fahrnheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
