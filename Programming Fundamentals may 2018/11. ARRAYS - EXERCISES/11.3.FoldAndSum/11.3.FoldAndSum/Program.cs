using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int k = numbers.Length / 4;
            int[] upperCase = new int[k * 2];
            int[] lowerCase = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                upperCase[i] = numbers[k - i - 1];
                upperCase[k + i] = numbers[numbers.Length - 1 - i]; //предпоследния
                //lowerCase[k + i] = numbers[k + i];
            }
            for (int i = 0; i < 2 * k; i++)
            {
                lowerCase[i] = numbers[k + i];
            }

            int[] sum = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                sum[i] = upperCase[i] + lowerCase[i];
            }
            Console.WriteLine(string.Join(" ", sum));

            //Console.WriteLine(String.Join(" ", FoldSum(numbers)));
        }

        /*static int[] FoldSum(int[] numbers)
        {

            int[] middleElements = new int[k * 2];
            int[] firstElement = new int[k];
            int[] lastElement = new int[k];
            int[] firstANDlast = new int[k * 2];

            //define lower row
            for (int i = 0; i < 2 * k; i++)
            {
                middleElements[i] = numbers[k + i];
            }

            //define upper row
            //first half

            for (int i = 0; i < k; i++)
            {
                firstElement[i] = numbers[i];
            }

            //second half

            for (int i = 0; i < k; i++)
            {
                lastElement[i] = numbers[i + 3 * k];
            }

            Array.Reverse(lastElement);
            Array.Reverse(firstElement);


            for (int i = 0; i < firstANDlast.Length; i++)
            {
                /*if (i < k)
                {
                    firstANDlast[i] = firstElement[i];
                }
                else
                {
                    firstANDlast[i] = lastElement[i - k];
                }
            }

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = firstElement[i];
            }
            return middleElements;
        }*/
    }
}
