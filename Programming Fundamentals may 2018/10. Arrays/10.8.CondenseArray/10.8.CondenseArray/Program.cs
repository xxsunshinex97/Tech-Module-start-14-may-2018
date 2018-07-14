using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._8.CondenseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var counter = numbers.Length;

            while (counter > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
                counter--;
            }
            Console.WriteLine(numbers[0]);
            /*int finalResult = 0;
            int firstLength = numbers.Length - 1;
            for (int i = 0; i < firstLength; i++)
            {
                int[] array = new int[numbers.Length - 1];
                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = numbers[j] + numbers[j + 1];
                    numbers = array;
                    finalResult = array[0];
                }
                Console.WriteLine(finalResult);
            }*/

        }
    }
}
