using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5.Special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int SumDigit = 0;
                int digits = i;
                while (digits > 0)
                {
                    SumDigit += digits % 10;
                    digits = digits / 10;
                }
                bool special = (SumDigit == 5) || (SumDigit == 7) || (SumDigit == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
