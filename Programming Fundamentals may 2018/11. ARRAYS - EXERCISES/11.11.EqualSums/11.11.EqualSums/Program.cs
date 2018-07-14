using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int output = 0;
            bool isValid = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    isValid = true;
                    Console.WriteLine(i);
                    break;
                    //output = i;
                }

            }
            if (isValid == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
