using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int diffeence = int.Parse(Console.ReadLine());

            int pairs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diffeence)
                    {
                pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
