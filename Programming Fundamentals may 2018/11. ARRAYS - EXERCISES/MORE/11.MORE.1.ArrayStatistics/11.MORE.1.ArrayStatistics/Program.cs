using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._1.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            /*printMinNumber(numbers);
            printMaxNumber(numbers);*/

            var min = int.MaxValue;
            var max = int.MinValue;
            int sum = 0;
            double average = 1.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (currentNum < min)
                {
                    min = currentNum;
                }

                if (currentNum > max)
                {
                    max = currentNum;
                }

                sum += currentNum;

                average = (double)sum / numbers.Length;
            }
            Console.WriteLine("Min = {0}\nMax = {1}\nSum = {2}\nAverage = {3}", min, max, sum, average);


        }

        /*static void printMaxNumber(int[] numbers)
        {
            Console.WriteLine("Min = {0}", numbers.Max());
            //n = numbers.Max(element => Math.Abs(element));
        }

        static void printMinNumber(int[] numbers)
        {
            Console.WriteLine("Max = {0}", numbers.Min());
        }*/
    }
}
