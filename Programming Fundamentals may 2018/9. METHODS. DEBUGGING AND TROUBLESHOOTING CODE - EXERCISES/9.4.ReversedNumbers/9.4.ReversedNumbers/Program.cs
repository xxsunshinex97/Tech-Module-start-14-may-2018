using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4.ReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNums(number));
        }

        static string ReversedNums(decimal n)
        {
            char[] arr = n.ToString().ToCharArray();
            string str = "";

            for (int i = arr.Length-1; i >= 0; i--)
            {
                str += arr[i];
            }
            return str;
        }
    }
}
