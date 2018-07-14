﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._14.MagicalLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine().ToLower(); // not printed

            string result = "";

            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        result = $"{i}{j}{k}";
                        if (!result.Contains(skip))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
        }
    }
}
