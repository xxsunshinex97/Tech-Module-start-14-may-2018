﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-ви начин:
            string ingredients;
            for (int i = 0; i <= 20; i++)
            {
                ingredients = Console.ReadLine();

                if (ingredients != "Bake!")
                {

                    Console.WriteLine($"Adding ingredient {ingredients}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }

            }

            //2-ри начин

            /*string input = Console.ReadLine();
            int ingredientsNum = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                ingredientsNum++;
            }
            Console.WriteLine($"Preparing cake with {ingredientsNum} ingredients.");*/
        }
    }
}
