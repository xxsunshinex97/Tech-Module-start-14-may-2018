using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._9.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int sum = 0;
            int currentIndex = 0;

            for (;;)
            {
                sum += numbers[currentIndex]; //start from the beginnig od the array
                if (currentIndex + numbers[currentIndex] < numbers.Length) //move right
                {
                    currentIndex = currentIndex + numbers[currentIndex];
                }
                else if (currentIndex - numbers[currentIndex] > 0) //move left
                {
                    currentIndex = currentIndex - numbers[currentIndex];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
