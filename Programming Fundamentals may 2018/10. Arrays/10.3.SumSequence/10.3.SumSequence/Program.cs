using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3.SumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0;
                if (i < k)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        sum += array[j];
                    }
                }
                else
                {
                    for (int j = i - k; j < array.Length; j++)
                    {
                        sum += array[j];
                    }
                }
                array[i] = sum;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
