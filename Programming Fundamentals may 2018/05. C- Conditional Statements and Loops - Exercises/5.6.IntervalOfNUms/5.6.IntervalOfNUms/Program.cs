﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6.IntervalOfNUms
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var maxNum = Math.Max(a,b);
            var minNum = Math.Min(a,b);
            //чрез Math.Min намираме най-малкото число от 2 числа.а при Math.Max е обратния случай

            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
