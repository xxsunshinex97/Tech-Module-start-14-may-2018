using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._7.InventoryMatcher
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
                //for (int i = 0; i < productsNames.Length; i++)
                //
                //string product = Console.ReadLine();


                int name = Array.IndexOf(productsNames, command);


                Console.WriteLine($"{command} costs: {priceProduct[name]}; Available quantity: {quantityProducts[name]}");

                command = Console.ReadLine();
                //}
            }

        }
    }
}
