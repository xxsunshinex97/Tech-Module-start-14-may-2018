using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11.Odd_number
{
    class Program
    {
        static void Main(string[] args)
        {

            /*for (int i = 0; i <= 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 != 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            
            }*/

            int number = int.Parse(Console.ReadLine());

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");

        }
    }
}
