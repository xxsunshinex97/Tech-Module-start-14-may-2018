using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int calories = 0;

            for (int i = 0; i < n; i++)
            {
                string ingrediednts = Console.ReadLine().ToLower();

                switch (ingrediednts)
                {
                    case "cheese":
                        calories += cheese;
                        break;
                    case "tomato sauce":
                        calories += tomatoSauce;
                        break;
                    case "salami":
                        calories += salami;
                        break;
                    case "pepper":
                        calories += pepper;
                        break;
                    default:
                        // get another something and try again
                        continue;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
            /*
            string ingrediednts;
            int calories = 0;

            for (int i = 0; i <= n; i++)
            {
                ingrediednts = Console.ReadLine().ToLower();

                if (ingrediednts == "cheese")
                {
                    calories = 500;
                }
                else if (ingrediednts == "tomato sauce")
                {
                    calories = 150;
                }
                else if (ingrediednts == "salami")
                {
                    calories = 600;
                }
                else if (ingrediednts == "pepper")
                {
                    calories = 50;
                }
                int totalAmount = 
        }*/
        }
    }
}
