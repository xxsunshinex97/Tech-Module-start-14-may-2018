using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12.IntToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string Hex = number.ToString("X");
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(Hex);
            Console.WriteLine(binary);

        }
    }
}
