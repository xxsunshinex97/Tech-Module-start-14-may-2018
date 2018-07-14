using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _9._13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
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
    }
}
