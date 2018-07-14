using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    Triangle();
                    break;
                case "square":
                    Square();
                    break;
                case "rectangle":
                    Rectangle();
                    break;
                case "circle":
                    Circle();
                    break;
            }
        }

        static void Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangle = (side * height) / 2;
            Console.WriteLine($"{triangle:F2}");
        }

        static void Square()
        {
            double side = double.Parse(Console.ReadLine());
            double square = Math.Pow(side, 2);
            Console.WriteLine($"{square:F2}");
        }

        static void Rectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectangle = width * height;
            Console.WriteLine($"{rectangle:F2}");
        }

        static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());
            double circle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{circle:F2}");
        }


    }
}
