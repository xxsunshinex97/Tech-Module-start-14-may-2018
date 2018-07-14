using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //var num =0;
            long num = long.Parse(Console.ReadLine());
            //num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long n)
        {
            bool primeCheck = true;

            if (n == 0 || n == 1)
            {
                primeCheck = false;
                return primeCheck;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); ++i)
                {
                    if (n % i == 0)
                    {
                        primeCheck = false; ;
                    } 
                }

                return primeCheck;
            }

            /*if (num == 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;*/

            /*if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }

            return true;*/
        }
    }
}
