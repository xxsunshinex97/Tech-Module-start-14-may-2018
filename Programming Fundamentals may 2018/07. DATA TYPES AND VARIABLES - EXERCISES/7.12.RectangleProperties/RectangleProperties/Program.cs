using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + heigth);
            double area = width * heigth;
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(heigth, 2));

            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");
        }
    }
}
