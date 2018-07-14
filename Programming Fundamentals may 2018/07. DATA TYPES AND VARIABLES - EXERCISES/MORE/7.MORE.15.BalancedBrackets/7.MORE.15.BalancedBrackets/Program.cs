using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._15.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;
            string balance = "BALANCED";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (output == "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    output = "(";
                }
                if (input == ")")
                {
                    if (output != "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    output = ")";
                }
            }
            if (output == "(")
            {
                balance = "UNBALANCED";
            }
            Console.WriteLine(balance);
        }
    }
}
