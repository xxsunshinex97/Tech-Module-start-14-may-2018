﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.Choose_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            if (profession == "Athelete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "Businessman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else 
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
