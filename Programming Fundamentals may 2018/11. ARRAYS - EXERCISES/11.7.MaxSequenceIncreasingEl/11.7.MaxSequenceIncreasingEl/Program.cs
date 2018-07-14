using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._7.MaxSequenceIncreasingEl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;
            //string equalEl = "";

            for (int i = 1; i < numbers.Length; i++)
            {
                int currentIndex = numbers[i];
                //int longest = 0;

                //for (int j = 0; j < i - 1; j++)
                //{
                if (currentIndex > numbers[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLen = 1;
                }
                //}
            }
            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
