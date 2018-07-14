using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._6.SquareNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            var output = new List<int>();

            for (int i = 0; i < input.Count(); i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    output.Add(input[i]);
                }
            }
            output.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
