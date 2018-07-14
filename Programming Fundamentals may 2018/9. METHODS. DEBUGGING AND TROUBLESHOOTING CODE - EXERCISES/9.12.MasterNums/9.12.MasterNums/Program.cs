using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._12.MasterNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isPolindrome = PolindromeCheck(i);
                bool isDivisibleSeven = digitSevenCheck(i);
                bool isEvenDigit = EvenDigitCheck(i);

                if (isPolindrome && isDivisibleSeven && isEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool PolindromeCheck(int n)
        {
            var number = n;
            var ReversedNum = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;
                ReversedNum = ReversedNum * 10 + lastDigit;
                n /= 10;
            }
            if (number == ReversedNum)
            {
                return true;
            }
            return false;
        }

        static bool digitSevenCheck(int n)
        {
            char[] c = n.ToString().ToCharArray();
            int sum = 0;

            for (int i = 0; i < c.Length; i++)
            {
                sum += (int)c[i] - (int)'0';
            }

            if (sum % 7 != 0)
            {
                return false;
            }

            return true;
        }

        static bool EvenDigitCheck(int n)
        {
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                n /= 10;
            }
            return false;
        }
    }
}
