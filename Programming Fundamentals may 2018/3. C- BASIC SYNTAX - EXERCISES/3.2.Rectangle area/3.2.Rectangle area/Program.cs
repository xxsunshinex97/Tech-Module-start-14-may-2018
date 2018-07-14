using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2.Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double RectArea = widht * height;

            Console.WriteLine($"{RectArea:F2}");
        }
    }
}
