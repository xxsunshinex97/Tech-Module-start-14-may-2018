using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Cordinate(x1, y1, x2, y2));
        }

        static string Cordinate(double x1, double y1, double x2, double y2)
        {
            string cordinate = "";

            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))  
            {
                cordinate = $"({x1}, {y1})";
            }
            else
            {
                cordinate = $"({x2}, {y2})";
            }
            return cordinate;
        }
    }
}
