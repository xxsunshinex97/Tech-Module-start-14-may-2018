using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._3.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {

                if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    try
                    {
                        input[int.Parse(command[1])] = command[2];
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", input));

        }
    }
}
