using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            object allstrings = input1 + " " + input2;
            string result = allstrings.ToString(); // casting

            Console.WriteLine(result);
        }
    }
}
