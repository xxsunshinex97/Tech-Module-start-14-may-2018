using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._8.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            long sum = 0;

            if (num1 >= 0 && num1 <= 127 && num2 >= 128 && num2 <= 2147483647)
            {
                sum = 4 * num1 + 10 * num2;
            }
            else if (num2 >= 0 && num2 <= 127 && num1 >= 128 && num1 <= 2147483647)
            {
                sum = 4 * num2 + 10 * num1;
            }


            Console.WriteLine(sum);
        }
    }
}
