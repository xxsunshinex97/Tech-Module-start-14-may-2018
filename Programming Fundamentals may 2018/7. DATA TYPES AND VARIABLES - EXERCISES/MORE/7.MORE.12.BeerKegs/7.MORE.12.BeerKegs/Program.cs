using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._12.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string biggestModel = "";
            double biggestVolume = 0;
            float pi = (float)Math.PI;

            while (n > 0)
            {
                string modelCurrent = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = pi * Math.Pow(radius, 2) * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestModel = modelCurrent;
                }
                n--;
            }
            Console.WriteLine(biggestModel);

            /*int n = int.Parse(Console.ReadLine());
            //double count = 0;
            //double sum = 0;
            double volume = 0;

            for (int i = 0; i < 3*n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;
                //sum += volume;
                //count--;
            }
            Console.WriteLine(volume);*/
        }
    }
}
