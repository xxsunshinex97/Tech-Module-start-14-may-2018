﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
