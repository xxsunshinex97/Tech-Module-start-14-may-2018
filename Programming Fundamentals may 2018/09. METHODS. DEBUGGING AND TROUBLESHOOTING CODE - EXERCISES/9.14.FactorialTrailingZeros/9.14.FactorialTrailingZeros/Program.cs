using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _9._14.FactorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial= Factorial(n);
            int zeros = CountZeros(factorial);
            Console.WriteLine(zeros);
        }

        static BigInteger Factorial(int n)
        {
            //BigInteger factorial = 1;


            if (n == 0)
            {
                return 1;
            }

            BigInteger result = n;

            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }

        static int CountZeros(BigInteger num)
        {
            int zeros = 0;

            bool hasZeros = true;
            while (hasZeros)
            {
                BigInteger digit = num % 10;
                num /= 10;
                if (digit == 0)
                {
                    zeros++;
                }
                else
                {
                    hasZeros = false;
                }                
            }
                return zeros;
        }
    }
}
