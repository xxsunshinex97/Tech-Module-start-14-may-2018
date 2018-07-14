using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.More._3.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfLines = short.Parse(Console.ReadLine());

            short capacity = 255;
            short capacityDif = capacity;
            for (short i = 0; i < numberOfLines; i++)
            {
                short quantityOfwater = short.Parse(Console.ReadLine());
                if (capacityDif - quantityOfwater >= 0)
                {
                    capacityDif -= quantityOfwater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            short filled = (short)(capacity - capacityDif);
            Console.WriteLine(filled);
        }
    }
}
