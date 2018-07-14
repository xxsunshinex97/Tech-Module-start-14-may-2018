using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5.FibonacciNums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNums(n));
        }

        static long FibonacciNums(long n)
        {
            long a = 0;
            long b = 1;
            long c = 1;

            for (long i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
