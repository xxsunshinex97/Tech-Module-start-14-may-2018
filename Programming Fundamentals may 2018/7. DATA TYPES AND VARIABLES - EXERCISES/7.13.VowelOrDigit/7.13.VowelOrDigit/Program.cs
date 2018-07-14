using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num;


            if (input.Contains("a") || input.Contains("e") || input.Contains("i") || input.Contains("o") || input.Contains("u"))
            {
                Console.WriteLine("vowel");
            }
            else if (int.TryParse(input, out num))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
