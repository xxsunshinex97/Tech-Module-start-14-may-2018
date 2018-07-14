using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.More._4.TouristInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            switch (type)
            {
                case "miles":
                    double kilometers = 1.6 * number;
                    Console.WriteLine($"{number} miles = {kilometers:F2} kilometers");
                    break;
                case "inches":
                    double centimeters = 2.54 * number;
                    Console.WriteLine($"{number} inches = {centimeters:F2} centimeters");
                    break;
                case "feet":
                    double centimeter = 30 * number;
                    Console.WriteLine($"{number} feet = {centimeter:F2} centimeters");
                    break;
                case "yards":
                    double meters = 0.91 * number;
                    Console.WriteLine($"{number} yards = {meters:F2} meters");
                    break;
                case "gallons":
                    double liters = 3.8 * number;
                    Console.WriteLine($"{number} gallons = {liters:F2} liters");
                    break;
            }
        }
    }
}
