using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._7.CountNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();

            int count = 1;
            int startIndex = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (i == nums.Count() - 1 || (nums[i] != nums[i + 1]))
                {
                    Console.WriteLine($"{nums[i]} -> {count}");
                    startIndex = i + 1;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
        }
    }
}
