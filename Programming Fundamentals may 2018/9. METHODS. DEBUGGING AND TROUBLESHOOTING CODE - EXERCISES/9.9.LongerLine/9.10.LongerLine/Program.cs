using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstCordinate = LineLength(x1, y1, x2, y2);
            double secondCordinate = LineLength(x3, y3, x4, y4);

            string result = "";
            if (firstCordinate >= secondCordinate)
            {
                result = Cordinate(x1, y1, x2, y2);
                Console.WriteLine(result);
            }
            else
            {
                result = Cordinate(x3, y3, x4, y4);
                Console.WriteLine(result);
            }

            //Console.WriteLine(Cordinate(x1, y1, x2, y2));
        }

        static double LineLength(double x1, double y1, double x2, double y2)
        {
            double differenceX = Math.Abs(x1- x2);
            double differenceY = Math.Abs(y1- y2);
            double line = Math.Sqrt(Math.Pow(differenceX, 2) + Math.Pow(differenceY, 2));
            return line;
        }

        static string Cordinate(double x1, double y1, double x2, double y2)
        {
            string cordinate = "";

            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
            {
                cordinate = $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                cordinate = $"({x2}, {y2})({x1}, {y1})";
            }
            return cordinate;
        }
    }
}
