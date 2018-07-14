using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._8.UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            long[] quantityProducts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
            decimal[] priceProduct = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => decimal.Parse(x)).ToArray();

            string command = Console.ReadLine();

            while (command != "done")
            {
                string product = command.Split(' ')[0];
                long quantity = long.Parse(command.Split(' ')[1]);

                int j = Array.IndexOf(productsNames, product);

                if (j < quantityProducts.Length && quantityProducts[j] >= quantity)
                {
                    Console.WriteLine($"{product} x {quantity} costs {priceProduct[j] * quantity:f2}");
                    quantityProducts[j] -= quantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product}");
                }
                command = Console.ReadLine();
            }
        }
    }
}
