using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._2.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else
                {
                    string[] replace = command.Split().ToArray();
                    input[int.Parse(replace[1])] = replace[2];
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
