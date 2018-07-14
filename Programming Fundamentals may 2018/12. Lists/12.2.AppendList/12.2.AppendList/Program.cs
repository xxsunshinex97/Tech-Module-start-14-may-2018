using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var result = new List<string>();

            Array.Reverse(input);
            foreach (var tokens in input)
            {
                string[] numbers = tokens.Split(' ');
                foreach (var item in numbers)
                {
                    if (item != " ")
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
