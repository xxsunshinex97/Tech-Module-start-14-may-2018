using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._4.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] array = new bool[n + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            if (array.Length == 1)
            {
                array[0] = false;
            }
            else
            {
                array[0] = false;
                array[1] = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j < n + 1; j+= i)
                    {
                        array[j] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (array[i])
                {
                Console.WriteLine(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
