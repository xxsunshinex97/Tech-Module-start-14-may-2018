using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._4.GrabGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int n = int.Parse(Console.ReadLine());

            GrabGo(numbers, n);

        }

        static void GrabGo(int[] numbers, int n)
        {
            long movement = 0;
            bool isEqual = false;

            for (int i = numbers.Length - 1; i >= 0; i--) //от дясно на ляво се движи
            {
                if (numbers[i] == n)
                {
                    isEqual = true;
                    for (int j = 0; j < i; j++)
                    {
                        movement += numbers[j];
                    }
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine(movement);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
