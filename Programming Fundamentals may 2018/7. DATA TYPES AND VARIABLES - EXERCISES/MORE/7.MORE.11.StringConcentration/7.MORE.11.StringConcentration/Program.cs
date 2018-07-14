using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._11.StringConcentration
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            //string input = Console.ReadLine();
            byte remainder = Console.ReadLine() == "even" ? (byte)0 : (byte)1;
            byte n = byte.Parse(Console.ReadLine());
            string concentrationStr = "";


            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == remainder)
                {
                    concentrationStr += Console.ReadLine() + delimeter;
                }
                else
                {
                    Console.ReadLine();
                }

            }
            Console.WriteLine(concentrationStr.Remove(concentrationStr.Length - 1));
        }
    }
}
