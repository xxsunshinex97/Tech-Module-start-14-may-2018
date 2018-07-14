using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1.Debitcard
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            string debitNum = $"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}";
            Console.WriteLine(debitNum);

        }
    }
}
