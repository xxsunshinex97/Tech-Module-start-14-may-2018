using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7.PrimeGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            CheckRange(num1, num2);
        }


        static void CheckRange(int num1, int num2)
        {
            List<int> numbers = new List<int>();
            if (num1 > num2)
            {
                Console.WriteLine("empty list");
                return;
            }
            if (num1 <= 1 || num2 < 0)
            {
                num1 = 2;
            }
            for (int i = num1; i <= num2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    numbers.Add(i);
                }
            }
            Print(numbers);
        }

        static void Print(List<int> numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }
            /*bool primeCheck = true;

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
            }*/
    }
}