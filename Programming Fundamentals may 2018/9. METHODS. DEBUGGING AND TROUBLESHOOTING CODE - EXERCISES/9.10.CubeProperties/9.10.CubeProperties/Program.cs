using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    GetFace(side);
                    break;
                case "space":
                    GetSpace(side);
                    break;
                case "volume":
                    GetVolume(side);
                    break;
                case "area":
                    GetArea(side);
                    break;
            }
        }

        static void GetFace(double side)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            Console.WriteLine($"{faceDiagonals:F2}");
        }

        static void GetSpace(double side)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            Console.WriteLine($"{spaceDiagonals:F2}");
        }

        static void GetVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"{volume:F2}");
        }

        static void GetArea(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            Console.WriteLine($"{area:F2}");
        }
    }
}
