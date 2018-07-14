using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2, n3;
            n1 = Console.ReadLine();
            n2 = Console.ReadLine();

            Console.WriteLine($"Before:\na = {n1}\nb = {n2}");
            n3 = n1;
            n1 = n2;
            n2 = n3;
            Console.WriteLine($"After:\na = {n1}\nb = {n2}");

        }
    }
}
