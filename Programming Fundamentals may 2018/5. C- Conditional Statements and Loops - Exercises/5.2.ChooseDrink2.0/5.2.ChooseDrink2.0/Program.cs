using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2.ChooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            if (profession == "Athlete")
            {
                price = 0.70;
                double payment = quantity * price; 
                Console.WriteLine($"The {profession} has to pay {payment:F2}.");

            }
            else if (profession == "Businessman")
            {
                price = 1.00;
                double payment = quantity * price;
                Console.WriteLine($"The {profession} has to pay {payment:F2}.");
            }
            else if (profession == "Businesswoman")
            {
                price = 1.00;
                double payment = quantity * price;
                Console.WriteLine($"The {profession} has to pay {payment:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70;
                double payment = quantity * price;
                Console.WriteLine($"The {profession} has to pay {payment:F2}.");
            }
            else
            {
                price = 1.20;
                double payment = quantity * price;
                Console.WriteLine($"The {profession} has to pay {payment:F2}.");
            }
        }
    }
}
