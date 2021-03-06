﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5.CharStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int remainingHealth = maxHealth - currentHealth;
            string remainingHealthString = new string('.', remainingHealth);
            string currentHealthString = new string('|', currentHealth);
            string health = $"|{currentHealthString}{remainingHealthString}|";

            int remainingEnergy = maxEnergy - currentEnergy;
            string remainingEnergyString = new string('.', remainingEnergy);
            string currentEnergyString = new string('|', currentEnergy);
            string energy = $"|{currentEnergyString}{remainingEnergyString}|";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
