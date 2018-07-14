using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._6.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int digit = 0;
            int max = 1;
            //string equalEl = "";

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentIndex = numbers[i];
                int longest = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentIndex == numbers[j])
                    {
                        longest++;
                        if (max < longest)
                        {
                            max = longest;
                            digit = currentIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < max; i++)
            {
                Console.Write(digit + " ");
            }
        }
    }
}
