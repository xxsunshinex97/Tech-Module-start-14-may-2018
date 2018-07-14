using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4.Triplesum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool hasFound = false;

            for (int second = 1; second < numbers.Length; second++)
            {
                for (int first = 0; first < second; first++)
                {
                    if (numbers.Contains(numbers[first] + numbers[second]))
                    {
                        hasFound = true;
                        Print(first, second, numbers[first] + numbers[second], numbers);
                    }
                }
            }
            if (!hasFound)
            {
                Console.WriteLine("No");
            }
        }

        static void Print(int a, int b, int sum, int[] numbers)
        {
            Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
        }
    }
}
