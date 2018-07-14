using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._9.MakeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sum = "";

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());

                sum += input;
            }
            Console.WriteLine($"The word is: {sum}");
        }
    }
}
