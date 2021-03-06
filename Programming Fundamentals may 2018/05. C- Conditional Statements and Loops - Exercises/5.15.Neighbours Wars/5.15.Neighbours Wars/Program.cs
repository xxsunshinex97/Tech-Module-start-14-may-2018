﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._15.Neighbours_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            int GoshoHealth = 100;
            int PeshoHelth = 100;

            int rounds = 1;

            while (true)
            {
                if (rounds % 2 == 1) // 1/2 == 1 => 0 е остатъка и започва Пешо
                {
                    GoshoHealth -= PeshoDamage;
                    if (GoshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                }
                else
                {
                    PeshoHelth -= GoshoDamage;
                    if (PeshoHelth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHelth} health.");
                    }
                }
                if (rounds % 3 == 0) // остатък 0 на всеки трети рунд добавя 10 health
                {
                    PeshoHelth += 10;
                    GoshoHealth += 10;
                }
                rounds++; //брои рундовете
            }
        }
    }
}
