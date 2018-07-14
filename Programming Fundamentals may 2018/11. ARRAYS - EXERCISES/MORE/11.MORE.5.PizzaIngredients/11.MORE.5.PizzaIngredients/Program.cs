using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._5.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split().ToArray();
            int searchedString = int.Parse(Console.ReadLine());

            Pizza(ingredients, searchedString);
        }

        static void Pizza(string[] input, int searchedString)
        {
            //while (input.Length <= 10)
            //{
            int counter = 0; //how much will be the ingredients
            string validIngredients = ""; //this is the possible ingredients

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToCharArray().Length == searchedString) // this is important check
                {
                    counter++;
                    validIngredients += input[i] + " ";
                    Console.WriteLine($"Adding {input[i]}.");
                    if (counter >= 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", validIngredients.Trim().Split(' ').ToArray())}.");
            //}
        }
    }
}
