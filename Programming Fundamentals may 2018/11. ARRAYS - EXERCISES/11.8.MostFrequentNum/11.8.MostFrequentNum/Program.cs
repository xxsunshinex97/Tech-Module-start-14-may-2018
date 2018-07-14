using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._8.MostFrequentNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int mostFreqNum = 0;
            int repetition = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                int currenttNumber = numbers[i];
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currenttNumber == numbers[j])
                    {
                            count++;
                    }
                }
                if (count > repetition)
                {
                    mostFreqNum = currenttNumber;
                    repetition = count;
                }
            }
            Console.WriteLine(mostFreqNum);
        }
    }
}
